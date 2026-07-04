; Lab4_1

format PE console
include 'win32a.inc'

entry start

section '.data' data readable writeable
    arr dd 5, -2, 8, 3, 10, -1, 0, 7, 4, 6
    k dd 4
    msg db 'Result: ', 0
    fmt db '%d ', 0
    newline db 13, 10, 0

section '.code' code readable executable

start:
    ; 1) Поиск максимума

    mov     esi, arr
    mov     ecx, 10
    mov     eax, [esi]          ; текущий максимум
    mov     edi, 1              ; индекс для проверки

.max_loop:
    cmp     edi, ecx
    jge     .found_max
    mov     ebx, [esi + edi*4]
    cmp     ebx, eax
    jle     .next_max
    mov     eax, ebx
.next_max:
    inc     edi
    jmp     .max_loop

.found_max:
    ; eax = максимальное значение (10)

    ; 2) Заменить первые k элементов на максимум

    mov     edi, 0
    mov     ecx, [k]            ; k = 4

.replace_loop:
    cmp     edi, ecx
    jge     .print
    mov     [esi + edi*4], eax
    inc     edi
    jmp     .replace_loop

    ; 3) Вывод массива (10 элементов)

.print:
    push    msg
    call    [printf]
    add     esp, 4

    mov     edi, 0
    mov     ebx, 10             ; используем EBX как счётчик

.print_loop:
    cmp     edi, ebx
    jge     .done

    push    dword [esi + edi*4]
    push    fmt
    call    [printf]
    add     esp, 8

    inc     edi
    jmp     .print_loop

.done:
    push    newline
    call    [printf]
    add     esp, 4

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