/******************************************************************************
Revisions:
    Rev Date                       Modified By                                    Description
*******************************************************************************/
string issueType = this.getProperty("issue_type", "");
Dictionary<string, string> propDict = new Dictionary<string, string> {
    {"_region", "Region"},
    {"_customer", "Customer"},
    {"_currency", "Currency"}
};
string emptyField = "";
int emptyCount = 0;
 
foreach (var prop in propDict) {
    string currProp = this.getProperty(prop.Key, "");
    if (currProp == "") {
        emptyField = emptyField + prop.Value + ", ";
        ++emptyCount;
    }
}
if (emptyCount == 1) {
    emptyField = emptyField.Remove(emptyField.Length - 2, 2); // remove the trailing ", " in emptyField
    return this.getInnovator().newError("New Requirement: " +  emptyField + " is a required field.");
}
else if (emptyCount > 1) {
    emptyField = emptyField.Remove(emptyField.Length - 2, 2); // remove the trailing ", " in emptyField
    int index = emptyField.LastIndexOf(", ");
    emptyField = emptyField.Insert(index + 1, " and ");
    return this.getInnovator().newError("New Requirements: " +  emptyField + "  are required fields.");
}
else {
    return this;
}
