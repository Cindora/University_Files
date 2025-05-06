A = {-2, -1, 0, 1, 2}

def in_relation(a, b):
    return a * a + b * b >= 4

for a in A:
    for b in A:
        if in_relation(a, b):
            print(f"({a}, {b}) находятся в отношении ({a * a + b * b} >= 4)")
        else:
            print(f"({a}, {b}) ({a * a + b * b} < 4)")
