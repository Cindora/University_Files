; lab2_2.asm
format PE GUI 4.0
include 'win32ax.inc'

.data
  Caption db 'Результат',0
  Text db 'Количество четных = %d',0
  buf rb 256
  x1 dd 2
  x2 dd 5
  x3 dd 8

.code
  start:
    xor ecx, ecx       ; счётчик
    mov eax, [x1]
    test eax, 1
    jnz n1
    inc ecx
  n1:
    mov eax, [x2]
    test eax, 1
    jnz n2
    inc ecx
  n2:
    mov eax, [x3]
    test eax, 1
    jnz n3
    inc ecx
  n3:
    invoke wsprintf, addr buf, addr Text, ecx
    invoke MessageBox, 0, addr buf, addr Caption, MB_OK
    invoke ExitProcess, 0
  .end start