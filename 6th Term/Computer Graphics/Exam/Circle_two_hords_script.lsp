(DEFUN C:CHORDS ( / PC R P1 P2 P3 P4)
  ; Запрос центра окружности
  (SETQ PC (GETPOINT "\Центр окружности: "))
  ; Запрос радиуса
  (SETQ R (GETDIST PC "\n Радиус окружности: "))
  
  ; Вычисляем точки хорд на окружности
  (SETQ P1 (POLAR PC 0 R))
  (SETQ P2 (POLAR PC 2 R))
  (SETQ P3 (POLAR PC 4 R))
  (SETQ P4 (POLAR PC 6 R))
  
  ; Чертим окружность и хорды
  (COMMAND "CIRCLE" PC R)
  (COMMAND "LINE" P1 P3 "")
  (COMMAND "LINE" P2 P4 "")
)