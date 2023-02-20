function setCssVariable(variableName, newValue) {
    document.documentElement.style.setProperty(`--${variableName}`, newValue);
    //alert('Called with: ' + variableName + ' = ' + newValue)
}