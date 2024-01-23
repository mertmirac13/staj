class ShiftReduceParser:
    def __init__(self, actions, goto, productions):
        self.actions = actions
        self.goto = goto
        self.productions = productions
        self.stack = [(0, None)]

    def parse(self, tokens):
        tokens = tokens + ['$']
        idx = 0

        while True:
            state = self.stack[-1][0]
            action = self.actions[state].get(tokens[idx])

            if action is None:
                print("Invalid expression")
                return

            if action.startswith('s'):  # shift action
                _, new_state = action[0], int(action[1:])
                self.stack.append((new_state, tokens[idx]))
                idx += 1

            elif action.startswith('r'):  # reduce action
                _, prod_index = action[0], int(action[1:])
                prod = self.productions[prod_index]

                # Pop the stack for each symbol in the production's right side
                self.stack = self.stack[:-len(prod['rhs'])]
                goto_state = self.goto[self.stack[-1][0]].get(prod['lhs'])

                # If goto state is None, then it's an invalid expression
                if goto_state is None:
                    print("Invalid expression")
                    return

                # Push the left side of the production and the goto state
                self.stack.append((goto_state, prod['lhs']))

                print(f"Reduced by rule {prod_index}: {prod['lhs']} -> {' '.join(prod['rhs'])}")

            elif action == 'accept':
                print("The input is successfully parsed.")
                return

            else:
                print("Invalid action")


        return self.stack

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
    # Index 0: This is a placeholder since the table starts from index 1
    {'lhs': '', 'rhs': []},
    # Rule 1: E -> E + T
    {'lhs': 'E', 'rhs': ['E', '+', 'T']},
    # Rule 2: E -> T
    {'lhs': 'E', 'rhs': ['T']},
    # Rule 3: T -> T * F
    {'lhs': 'T', 'rhs': ['T', '*', 'F']},
    # Rule 4: T -> F
    {'lhs': 'T', 'rhs': ['F']},
    # Rule 5: F -> ( E )
    {'lhs': 'F', 'rhs': ['(', 'E', ')']},
    # Rule 6: F -> id
    {'lhs': 'F', 'rhs': ['id']},
]


# Example of input tokens
input_tokens = ['id', '+', 'id', '*', 'id']

# Create a parser object with the tables and productions
parser = ShiftReduceParser(actions, goto, productions)

# Parse the input tokens
parser.parse(input_tokens)
