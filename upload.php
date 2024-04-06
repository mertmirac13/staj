<?php 
    require_once "auth.php";
?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="upload.css">
    
    <link href="froala_editor\css\froala_editor.pkgd.min.css" rel="stylesheet" type="text/css" />

    <title>Blog Yükleme</title>


</head>
<body class="bodyimg">
<h1 style="color:#fff;" class="title">Yazı Kaydetme</h1>
    <?php
    if (isset($_SESSION["name"])) {
      $yazar = $_SESSION["name"];     
  }
    
   if ($_SERVER["REQUEST_METHOD"] === "POST") {
    $conn = new mysqli("localhost", "root", "", "blog");
    if ($conn->connect_errno > 0) {
        die("<b>Bağlantı Hatası:</b> " . $conn->connect_error);
    }

    // değişkenlerin değerlerini POST süperglobal değişkeniyle alır trim baştaki ve sondaki boşlukları siler
    $baslik = trim($_POST["baslik"]);
    $kategori = $_POST["kategori"];
    $yazi = trim($_POST["yazi"]); 

    // Hata yoksa diğer sayfaya yönlendirir.
    if (!empty($baslik) && !empty($yazi) && !empty($_FILES["file"]["name"])) {
        $tarih = date('Y/m/d');
        
        // Dosya yükleme işlemi
        $target_dir = ""; 
        $target_file = $target_dir . basename($_FILES["file"]["name"]);
        if (move_uploaded_file($_FILES["file"]["tmp_name"], $target_file)) {
            $resim = $target_file;

            // Veritabanına kayıt işlemi
            $sql = "INSERT INTO `yazilar`(`baslik`, `tarih`, `yazi`, `resim`, `kategori`, `yazar`) VALUES ('$baslik','$tarih','$yazi','$resim','$kategori','$yazar')";
            if (mysqli_query($conn, $sql)) {
                header("Location: success.php");
                exit();
            } else {
                echo "Error: " . $sql . "<br>" . mysqli_error($conn);
            }
        } else {
            echo "Resim yüklenirken bir hata oluştu.";
        }

        mysqli_close($conn);
    }
}
?>
    <form method="post" style="display" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" enctype="multipart/form-data">
        <div class="box">
            <div class="baslik-container">
                <label style="color:#fff;" for="baslik">Başlık</label>
                <input type="text" id="baslik" name="baslik" value="" required>           
            </div>
                           
            <div class="yazi-container">
                <label for="yazi">Yazı:</label>
                <textarea type="text" id="yazi" name="yazi" value="" required></textarea>               
            </div>
           
            <div class="resim-container">
                <input type="file" id="file" name="file" required>                
            </div>
            
            <div class="ctg-container">
                <label style="color:#fff;" for="kategori"></label>
                <select class="category" name="kategori" id="kategori">
                    <option value="Science">Science</option>
                    <option value="Physic">Physics</option> 
                    <option value="Chemistry">Chemistry</option> 
                    <option value="Software">Software</option> 
                </select>
            </div>

            <div class="register-btn" >
                <input onclick="deneme()" type="submit" value="Yükle">
            </div>  
        </div>
    </form>
</body>
</html>

<script type="text/javascript" src="froala_editor\js\froala_editor.pkgd.min.js"></script>
<script> new FroalaEditor("#yazi")</script>

<script>    
  const inputs = document.querySelectorAll('.box input');
  inputs.forEach(function(input) {
    input.addEventListener('focus', function() {
      const label = this.parentElement.querySelector('label');
      label.style.top = '0';
      label.style.color = 'transparent';
    });

    input.addEventListener('blur', function() {
      const label = this.parentElement.querySelector('label');
      if (!this.value) {
        label.style.top = '';
        label.style.color = '#2b2e4a';
      }
    });   
  });
    

</script>