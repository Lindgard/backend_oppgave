# Oppgave om programflyt

## Todo

- [x] bestemme meg for hva switchen skal gjelde
- [x] Pseudokode som viser plan
- [x] skrive enkle løsninger som ikke er for store i scope
- [x] Se på å legge til Fahrenheit conversion.
- [x] gjøre Fahrenheit og Celsius optional

### Testing

Testet programmet jevnlig med å legge inn både negative tall som -3 og positive
tall med jevne mellomrom for å sjekke alle svarene switchen min skal gi. La
etterhvert til mer spacing og litt pynt for å gjøre det enklere å se responsen i
terminalen.

## How to

Initier nix

```sh
nix develop
```

Start programmet med følgende kommando

```sh
dotnet run
```

### Theme

Temperatur gitt som input i terminal.

### Pseudocode

FUNCTION Main() PRINT "Enter a temperature in Celsius:"

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
                  PRINT "The weather is mild."
                  BREAK

            CASE temperature > 25 AND temperature <= 35:
                  PRINT "It's really warm outside."
                  BREAK

            CASE temperature > 35:
                  PRINT "It's stupid hot outside."
                  BREAK

            DEFAULT:
                  PRINT "Unknown temperature range."
      END SWITCH

END FUNCTION

#### Oppdatert pseudokode fra chatGPT

START PROGRAM

CALL PrintHeader()

DISPLAY "Select a temperature unit" DISPLAY "1 = Celsius" DISPLAY "2 =
Fahrenheit" READ user choice

SET useCelsius = (choice == "1")

DISPLAY confirmation of selected unit

LOOP FOREVER DISPLAY input prompt (with separators) READ input

    IF input equals "exit"
        DISPLAY goodbye message
        BREAK loop
    END IF

    IF input can be parsed as a number
        STORE parsed number as temperatureInput

        IF useCelsius is TRUE
            temperatureCelsius = temperatureInput
            temperatureFahrenheit = convert C → F
        ELSE
            temperatureFahrenheit = temperatureInput
            temperatureCelsius = convert F → C
        END IF

        DISPLAY result header

        SWITCH on temperatureCelsius
            CASE <= 0:
                DISPLAY freezing message
            CASE > 0 AND <= 15:
                DISPLAY chilly message
            CASE > 15 AND <= 25:
                DISPLAY mild message
            CASE > 25 AND <= 35:
                DISPLAY hot message
            CASE > 35 AND <= 45:
                DISPLAY very hot message
            CASE > 45:
                DISPLAY dangerous heat message
        END SWITCH

        DISPLAY end of result block
    ELSE
        DISPLAY "Invalid input"
    END IF

    PRINT empty line for readability

END LOOP

END PROGRAM

FUNCTION PrintHeader: CLEAR screen DISPLAY title banner END FUNCTION

### Personlig review

Merket at ting løsnet da jeg kom meg gjennom å lage et par cases i switchen,
syntax ble enklere å forstå for meg. Slet en stund med å forstå scope av diverse
ting, spesielt når jeg begynte å ekspandere funksjonaliteten, men det gikk seg
til og jeg må bare huske å ta meg det ekstra minuttet til å lese koden min en
ekstra gang så blir scopingen lettere å følge.
