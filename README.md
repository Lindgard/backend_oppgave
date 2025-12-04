# Oppgave om programflyt

## Todo

- [x] bestemme meg for hva switchen skal gjelde
- [ ] Pseudokode som viser plan
- [ ] Lag nødvendige filer (Interface, class, controller?) for MVC design
      pattern
- [ ] skrive enkle løsninger som ikke er for store i scope

## Mål med programmet

Bruke w3schools og input i console til å generere et resultat basert på en
switch/if.

### Theme

Temperatur.

### Pseudocode

FUNCTION Main()
PRINT "Enter a temperature in Celsius:"

      READ userInput

      IF userInput can't be converted to an integer
            PRINT "Invalid input. Please enter a number."
            EXIT FUNCTION
      END IF

      SET temperature = converted integer value of input

      SWITCH (temperature)
            CASE temperature <= 0:
                  PRINT "It's freezing."
                  BREAK

            CASE temperature > 0 AND temperature <= 15:
                  PRINT "It's pretty chilly."
                  BREAK

            CASE temperature > 15 AND temperature <= 25:
