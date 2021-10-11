#Party Reservation Filter

##This filtering module application can filter list of party members. The console needs to receive a sequence of commands that specify whether you need to add or remove a given filter.

###Each cmd is in the given format "{command;filter type;filter parameter}"
###Cmds: "Add filter", "Remove filter", "Print"
###Filters: "Starts with", "Ends with", "Length", "Contains"

####Example input: Peter Misha Slav
####Add filter;Starts with;P
####Add filter;Starts with;M
####Print
