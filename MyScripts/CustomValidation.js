function validate()
{
    debugger;
    var isValid;
    if($("#txtOwner").val()=='')
    {
        alert('Please Enter Owner Name');
        $("#txtOwner").focus();
        return false;
    }

    if ($("#txtManufacturer").val() == '') {
        alert('Please Enter Vehicle Manufacturer');
        $("#txtManufacturer").focus();
        return false;
    }

    if ($("#txtVehicle").val() == '') {
        alert('Please Enter Vehicle Name');
        $("#txtVehicle").focus();
        return false;
    }
    if ($("#txtChasis").val() == '') {
        alert('Please Enter Chasis No. of Vehicle');
        $("#txtChasis").focus();
        return false;
    }
    if ($("#txtColor").val() == '') {
        alert('Please Enter Color of Vehicle');
        $("#txtColor").focus();
        return false;
    }

    if ($("#txtEngine").val() == '') {
        alert('Please Enter Engine Capacity of Vehicle');
        $("#txtEngine").focus();
        return false;
    }
    return true;
}