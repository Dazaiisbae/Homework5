const history = [];

function handleShapeRequest(request) {
    let result = 0;
    
    // Problem 2: UI/Side effects inside the calculation logic
    const statusMsg = `Processed ${request.name} with area ${result}`;
    document.getElementById("status-display").innerText = statusMsg; 
    
    console.log("Audit Log:", statusMsg);
    history.push({ item: request.name, val: result, time: Date.now() });
}