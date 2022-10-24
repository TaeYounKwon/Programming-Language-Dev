; AUTHOR: Michael Koepp
; DATE: 1/12/2022
; DESCRIPTION: First x86 Assembly Program

.586
.MODEL FLAT

.STACK  4096            ; reserve 4096-byte stack

.DATA                   ; reserve storage for data
number  DWORD   -105
sum     DWORD   ?


.CODE                           ; start of main program code
main    PROC
        mov     eax, number     ; first number to EAX
        add     eax, 2			; add 
        mov     sum, eax        ; sum to memory

        mov   eax, 0            ; exit with return code 0
        ret
main    ENDP

END                             ; end of source code
