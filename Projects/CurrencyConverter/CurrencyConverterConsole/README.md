## Currency Information Application

This C# console application is a simple program that provides an interactive interface for users to view currency exchange rates. The application allows users to navigate among currency options, view the buying and selling prices of a specific currency, and examine general information about all currencies.

### Key Features:

1. **Currency Options:**
    - Offers an array containing popular currencies such as US Dollar, Euro, British Pound, etc.
    - Allows the user to select a specific currency by its number.
2. **View Currency Information:**
    - When the user selects a specific currency, the program fetches the current exchange rate data from uzmanpara.milliyet.com.tr using web scraping.
    - Displays the buying and selling prices on the screen.
3. **View All Currencies:**
    - When the user wants to see all currencies, the program prints the buying and selling prices of all currencies.
4. **User-Friendly Interface:**
    - Enables user navigation within the application with a user-friendly menu.
    - Provides validation of user inputs and informative messages in case of invalid inputs.
5. **Exit Option:**
    - When the user wants to exit the application, the program terminates with an appropriate message.

### Usage:

1. **Selecting Currency:**
    - The user selects the desired currency from the menu on the screen.
    - Can view all currency information by pressing "0".
    - Can exit the application by pressing "99".
2. **Viewing Currency Information:**
    - The information of the selected currency or all currencies is fetched live from uzmanpara.milliyet.com.tr and displayed on the screen.
    - Informative messages are provided in case of invalid selections or inputs.
3. **Continuation:**
    - Reminds the user to press any key to continue.
    - Upon keypress, the user returns to the menu.

### Code Structure:

- **Program Class:**
    - Contains the main logic of the application.
    - Manages user selections and performs the relevant operations.
- **Currency Class:**
    - Provides an object model containing buying and selling prices.
- **GetCurrencyInfo Method:**
    - Fetches currency information using web scraping with HtmlAgilityPack.
    - Selects the target element with the specified XPath.
- **CurrencyNames Array:**
    - Contains the currency options that the program will present to the user.
