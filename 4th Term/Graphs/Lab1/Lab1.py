# Множества A, B, C, U (универсальное)
A = set([130, 133, 135, 137, 139])
B = set([133, 136, 137, 140, 142])
C = set([135, 136, 137, 141, 143])
D = set([137, 138, 139, 140, 144])

U = A.union(B).union(C).union(D)

print("Множества:")
print("A:", A)
print("B:", B)
print("C:", C)
print("D:", D)
print(f"U (универсальное): {U}\n")

# Дополнения
input("Для вычисления дополнений нажмите Enter")
notA = U.difference(A)
notB = U.difference(B)
notC = U.difference(C)

print(f"ㄱA: {notA} \nㄱB: {notB} \nㄱC: {notC}\n")

# Пересечения
input("Для вычисления пересечений нажмите Enter")

A_and_notC = A.intersection(notC)
notB_and_C_and_notA = notB.intersection(C).intersection(notA)

print(f"A ∩ ㄱC: {A_and_notC} \nㄱB ∩ C ∩ ㄱ A: {notB_and_C_and_notA}\n")

# Объединение
input("Для вычисления объединения нажмите Enter")
A_and_notC_or_notB_and_C_and_notA = A_and_notC.union(notB_and_C_and_notA)

print("A ∩ ㄱC ∪ ㄱB ∩ C ∩ ㄱ A:", A_and_notC_or_notB_and_C_and_notA)
