def shift_reduce_parser(actions, goto, productions, tokens):
    tokens = tokens + ['$']
    idx = 0
    stack = [(0, None)]

    while True:
        state = stack[-1][0]
        action = actions[state].get(tokens[idx])

        if action is None:
            print("Invalid expression")
            return

        if action.startswith('s'):
            _, new_state = action[0], int(action[1:])
            stack.append((new_state, tokens[idx]))
            idx += 1

        elif action.startswith('r'):
            _, prod_index = action[0], int(action[1:])
            prod = productions[prod_index]

            stack = stack[:-len(prod['rhs'])]
            goto_state = goto[stack[-1][0]].get(prod['lhs'])

            if goto_state is None:
                print("Invalid expression")
                return
            stack.append((goto_state, prod['lhs']))
        
        elif action == 'accept':
            print("The input is successfully parsed.")
            return

        else:
            print("Invalid action")

    return stack

actions = {
    0: {'id': 's5', '+': None, '*': None, '(': 's4', ')': None, '$': None},
    1: {'id': None, '+': 's6', '*': None, '(': None, ')': None, '$': 'accept'},
    2: {'id': None, '+': 'r2', '*': 's7', '(': None, ')': 'r2', '$': 'r2'},
    3: {'id': None, '+': 'r4', '*': 'r4', '(': None, ')': 'r4', '$': 'r4'},
    4: {'id': 's5', '+': None, '*': None, '(': None, ')': 's4', '$': None},
    5: {'id': None, '+': 'r6', '*': 'r6', '(': None, ')': 'r6', '$': 'r6'},
    6: {'id': 's5', '+': None, '*': None, '(': 's4', ')': None, '$': None},
    7: {'id': 's5', '+': None, '*': None, '(': 's4', ')': None, '$': None},
    8: {'id': None, '+': 's6', '*': None, '(': 's11', ')': None, '$': None},
    9: {'id': None, '+': 'r1', '*': 's7', '(': None, ')': 'r1', '$': 'r1'},
    10: {'id': None, '+': 'r3', '*': 'r3', '(': None, ')': 'r3', '$': 'r3'},
    11: {'id': None, '+': 'r5', '*': 'r5', '(': None, ')': 'r5', '$': 'r5'}
}

goto = {
    0: {'E': 1, 'T': 2, 'F': 3},
    1: {'E': None, 'T': None, 'F': None},
    2: {'E': None, 'T': None, 'F': None},
    3: {'E': None, 'T': None, 'F': None},
    4: {'E': 8, 'T': 2, 'F': 3},
    5: {'E': None, 'T': None, 'F': None},
    6: {'E': None, 'T': 9, 'F': 3},
    7: {'E': None, 'T': None, 'F': 10},
    8: {'E': None, 'T': None, 'F': None},
    9: {'E': None, 'T': None, 'F': None},
    10: {'E': None, 'T': None, 'F': None},
    11: {'E': None, 'T': None, 'F': None},
}

productions = [
    {'lhs': '', 'rhs': []},
    {'lhs': 'E', 'rhs': ['E', '+', 'T']},
    {'lhs': 'E', 'rhs': ['T']},
    {'lhs': 'T', 'rhs': ['T', '*', 'F']},
    {'lhs': 'T', 'rhs': ['F']},
    {'lhs': 'F', 'rhs': ['(', 'E', ')']},
    {'lhs': 'F', 'rhs': ['id']},
]

input_tokens = input("Enter the tokens (separated by space): ").split()
shift_reduce_parser(actions, goto, productions, input_tokens)