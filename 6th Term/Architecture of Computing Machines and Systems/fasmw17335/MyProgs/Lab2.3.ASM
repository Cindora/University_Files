; lab2_3.asm

format PE GUI 4.0
include 'win32ax.inc'

.data
  Caption db 'Результат',0
  Text db 'Результат игры: %s',0
  buf rb 256
  score dd 3
  win db 'Выигрыш',0
  draw db 'Ничья',0
  lose db 'Проигрыш',0
  unknown db 'Некорректное количество очков',0

.code
  start:
    mov eax, [score]
    cmp eax, 3
    je is_win
    cmp eax, 1
    je is_draw
    cmp eax, 0
    je is_lose
    mov esi, unknown
    jmp output
  is_win:
    mov esi, win
    jmp output
  is_draw:
    mov esi, draw
    jmp output
  is_lose:
    mov esi, lose
  output:
    invoke wsprintf, addr buf, addr Text, esi
    invoke MessageBox, 0, addr buf, addr Caption, MB_OK
    invoke ExitProcess, 0
  .end start