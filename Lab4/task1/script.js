function generateTable() {
    // n - table size
    let n = document.getElementById('tableSize').value;
    n = parseInt(n);

    if (isNaN(n) || n < 5 || n > 20) {
        document.getElementById('warning').textContent = 'Invalid input! Default value is 10.';
        n = 10;
    } else {
        document.getElementById('warning').textContent = '';
    }

    let table = document.getElementById('multiplicationTable');
    table.innerHTML = ''; // Clear the table before generating new one

    // Generate header row
    let header = table.insertRow();
    for (let i = 0; i <= n; i++) {
        let headerCell = document.createElement(i == 0 ? 'th' : 'td');
        headerCell.textContent = i == 0 ? '' : getRandomInt(1, 99);
        header.appendChild(headerCell);
    }

// Generate table rows
    for (let i = 1; i <= n; i++) {
        let row = table.insertRow();
        for (let j = 0; j <= n; j++) {
            let cell = row.insertCell();
            if (j === 0) {
                // Create a text node with the random number
                let randomNum = getRandomInt(1, 99);
                let textNode = document.createTextNode(randomNum);

                // Create a table header element and append the text node to it
                let th = document.createElement('th');
                th.appendChild(textNode);

                // Append the table header element to the cell
                cell.appendChild(th);
            } else {
                let val = parseInt(header.cells[j].textContent) * parseInt(row.cells[0].textContent);
                cell.textContent = val;
                if (val % 3 === 0) {
                    cell.className = 'rem0'; // green
                } else if (val % 3 === 1) {
                    cell.className = 'rem1'; // pink
                } else if (val % 3 === 2) {
                    cell.className = 'rem2'; // blue
                }
            }
        }
    }

}

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}
