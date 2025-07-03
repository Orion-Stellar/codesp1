Algoritmo booleancalc
boolean seguir = true
MIENTRAS seguir == true HACER
    MOSTRAR "Ingrese primer número:"
    LEER numero1
    MOSTRAR "Ingrese operador (+, -, *, /):"
    LEER operador
    MOSTRAR "Ingrese segundo número:"
    LEER numero2
    SI operador ES "+"
        resultado = numero1 + numero2
    SINO SI operador ES "-"
        resultado = numero1 - numero2
    SINO SI operador ES "*"
        resultado = numero1 * numero2
    SINO SI operador ES "/"
        SI numero2 != 0
            resultado = numero1 / numero2
        SINO
            MOSTRAR "Error: No se puede dividir entre cero."
            CONTINUAR
    SINO
        MOSTRAR "Operador inválido."
        CONTINUAR
    MOSTRAR "Resultado: ", resultado
    MOSTRAR "¿Desea hacer otra operación? (true/false):"
    LEER respuestaTexto
    SI respuestaTexto ES "true"
        seguir = true
    SINO
        seguir = false
FIN MIENTRAS
MOSTRAR "Gracias por usar la calculadora."
FINALGORITMO
