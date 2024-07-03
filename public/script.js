document.getElementById('send-button').addEventListener('click', sendMessage);

async function sendMessage() {
    const inputBox = document.getElementById('user-input');
    const message = inputBox.value.trim();

    if (message) {
        // Add user message to chat
        addMessageToChat('user', message);

        // Clear input box
        inputBox.value = '';

        try {
            // Call the API to get the response
            const response = await getBotResponse(message);
            addMessageToChat('gemini', response);
        } catch (error) {
            console.error('Error getting bot response:', error);
            addMessageToChat('gemini', 'Sorry, something went wrong. Please try again later.');
        }
    }
}

function addMessageToChat(role, message) {
    const chatBox = document.querySelector('.chat-box');
    const messageDiv = document.createElement('div');
    messageDiv.classList.add('message', role);

    const messageContent = document.createElement('div');
    messageContent.classList.add('message-content');
    messageContent.innerHTML = parseMessage(message);

    const span = document.createElement('span');
    span.textContent = role === 'gemini' ? 'TALAI' : 'SİZ';
    span.classList.add('label');

    if (role === 'gemini') {
        messageDiv.appendChild(span);
        messageDiv.appendChild(messageContent);
    } else {
        messageDiv.appendChild(messageContent);
        messageDiv.appendChild(span);
    }

    chatBox.appendChild(messageDiv);
    chatBox.scrollTop = chatBox.scrollHeight;
}

function parseMessage(message) {
    // ** ile belirtilen metni kalın yap
    let parsedMessage = message.replace(/\*\*(.*?)\*\*/g, '<strong>$1</strong>');

    // Yıldız (*) ile başlayan satırları liste öğelerine dönüştür
    parsedMessage = parsedMessage.replace(/^\*\s+/gm, '<li>');

    // Satır sonlarını kapatmak için liste öğeleri ekle
    parsedMessage = parsedMessage.replace(/\n/g, '</li>');

    return parsedMessage;
}

async function getBotResponse(message) {
    const response = await fetch('/api/message', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ message })
    });

    if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
    }

    const data = await response.json();
    return data.response;
}
