; lab2_1.asm
format PE GUI 4.0
include 'win32ax.inc'

.data
  Caption db 'Результат',0
  Text db 'Второе число = %d',0
  buf rb 256
  num1 dd 10
  num2 dd 2

.code
  start:
    mov eax, [num2]
    imul eax, eax      ; квадрат второго
    cmp eax, [num1]
    jge skip           ; если квадрат >= первого, ничего не делаем
    mov eax, [num2]
    imul eax, 6
    mov [num2], eax
  skip:
    invoke wsprintf, addr buf, addr Text, [num2]
    invoke MessageBox, 0, addr buf, addr Caption, MB_OK
    invoke ExitProcess, 0
  .end start