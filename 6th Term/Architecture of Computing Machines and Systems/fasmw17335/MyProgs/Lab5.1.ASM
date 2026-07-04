; Lab5.1

format PE console
include 'win32a.inc'

entry start

section '.data' data readable writeable
    ; массив 3 строки по 5 элементов
    ; индексы: строка*5 + столбец
    arr dd 1, -2, 3, 4, 5, \
           6, 7, -8, 9, 10, \
           -11, 12, 13, 14, 15

    rows = 3
    cols = 5
    msg db 'Massiv result:', 13, 10, 0
    fmt db '%4d ', 0
    newline db 13, 10, 0
    sum_msg db 'Summa 2 stolbca: %d', 13, 10, 0

section '.code' code readable executable

start:
    mov     esi, arr

    ; 1) Обмен: (3,4) <-> (1,2)
    ; индексы (0-based): 
    ;   (3,4) -> строка=2, столбец=3 -> idx = 2*5+3 = 13
    ;   (1,2) -> строка=0, столбец=1 -> idx = 0*5+1 = 1

    mov     eax, [esi + 13*4]   ; arr[2][3] = 14
    mov     ebx, [esi + 1*4]    ; arr[0][1] = -2
    mov     [esi + 1*4], eax    ; arr[0][1] = 14
    mov     [esi + 13*4], ebx   ; arr[2][3] = -2

    ; 2) Сумма элементов 2-го столбца (столбец = 1)
    ;    элементы: arr[0][1], arr[1][1], arr[2][1]
    ;    индексы: 1, 6, 11

    xor     eax, eax
    add     eax, [esi + 1*4]    ; arr[0][1]
    add     eax, [esi + 6*4]    ; arr[1][1]
    add     eax, [esi + 11*4]   ; arr[2][1]
    push    eax
    push    sum_msg
    call    [printf]
    add     esp, 8

    ; 3) Все положительные элементы увеличить на 3

    mov     ecx, 15             ; rows * cols = 15
    xor     edi, edi            ; индекс

.pos_loop:
    cmp     edi, ecx
    jge     .print
    cmp     dword [esi + edi*4], 0
    jle     .pos_next
    add     dword [esi + edi*4], 3
.pos_next:
    inc     edi
    jmp     .pos_loop

    ; 4) Вывод массива по строкам

.print:
    push    msg
    call    [printf]
    add     esp, 4

    mov     edi, 0              ; счётчик строк (0..2)

.row_loop:
    cmp     edi, rows
    jge     .done

    mov     ebx, 0              ; счётчик столбцов (0..4)

.col_loop:
    cmp     ebx, cols
    jge     .next_row

    ; вычисляем смещение: (строка * 5 + столбец) * 4
    ; используем EAX для вычисления
    mov     eax, edi            ; EAX = строка
    imul    eax, cols           ; EAX = строка * 5
    add     eax, ebx            ; EAX = строка * 5 + столбец
    shl     eax, 2              ; EAX = (строка * 5 + столбец) * 4

    push    dword [esi + eax]
    push    fmt
    call    [printf]
    add     esp, 8

    inc     ebx
    jmp     .col_loop

.next_row:
    push    newline
    call    [printf]
    add     esp, 4
    inc     edi
    jmp     .row_loop

.done:
    call [getchar]

    push    0
    call    [ExitProcess]

section '.idata' import data readable writeable
    library kernel32, 'kernel32.dll', \
            msvcrt,   'msvcrt.dll'

    import kernel32, \
           ExitProcess, 'ExitProcess'

    import msvcrt, \
           printf, 'printf', \
           getchar, 'getchar'