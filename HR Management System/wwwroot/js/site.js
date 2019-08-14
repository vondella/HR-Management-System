//$(document).ready(function () {
//        var maxAppend = 0;
//        $("#add_more").click(function () {
//            if (maxAppend >= 9) {
//                alert("Maximum 10 File is allowed");
//            } else {
//                var add_new = $('<div class="form-group">\n\
//                <label for="field-1" class="col-sm-3 control-label">Add Designations <span class="required"> *</span></label>\n\
//                    <div class="col-sm-5">\n\<input type="text" name="designations[]" value="" class="form-control" placeholder="Enter Your Designations"/>\n\
//    </div>\n\
//    <div class="col-sm-2">\n\
//    <strong><a href="javascript:void(0);" class="remCF"><i class="fa fa-times"></i>&nbsp;Remove</a></strong>\n\
//    </div>');
//                maxAppend++;
//                $("#add_new").append(add_new);
//            }
//        });

//        $("#add_new").on('click', '.remCF', function () {
//            $(this).parent().parent().parent().remove();
//        });
//    });





// department section
var designation_id_count = 2;



function addMoreDesignationField() {

    var container = document.getElementById("DesignationContainer");
    var div = document.createElement("div");
    div.classList.add("form-group");
    var id = "designation" + designation_id_count;
    div.setAttribute("id", id);
    designation_id_count++;

    var label_element = document.createElement("label");
    label_element.classList.add("col-sm-3");
    label_element.classList.add("control-label");


    var span = document.createElement("span");
    span.classList.add("required");
    span.setAttribute("aria-required", "true");
    span.innerText = "*";


    label_element.appendChild(span);
    label_element.innerText = "Add Designations";

    div.appendChild(label_element);


    var child_div = document.createElement("div");
    child_div.classList.add("col-sm-5");

    var input_child = document.createElement("input");
    input_child.setAttribute("type", "text");
    input_child.name = "designations[]";
    input_child.classList.add("form-control");
    input_child.setAttribute("placeholder", "Enter Your Designations");

    child_div.appendChild(input_child);

    div.appendChild(child_div);

    child_div = document.createElement("div");
    child_div.classList.add("col-sm-2");

    var strong_child = document.createElement("strong");
    var a_child = document.createElement("a");
    a_child.setAttribute("href", "javascript:void(0);");

    a_child.classList.add("remCF");
    a_child.innerHTML = "<i class='fa fa - times'></i>&nbsp;Remove";

    a_child.setAttribute("onclick", `RemoveDesignationFromForm("${id}")`);
    //alert(id);
    strong_child.appendChild(a_child);
    child_div.appendChild(strong_child);
    div.appendChild(child_div);
    container.appendChild(div);

}



function RemoveDesignationFromForm(child_id) {
    if (child_id != "" && child_id != null) {
        var container = document.getElementById("DesignationContainer");
        var child = document.getElementById(child_id);
        container.removeChild(child);
    }
}



function RemoveDesignationFromForm(id, containerId) {

}




function AddMoreDesignationFieldInEditdepartment(designationContainerID) {

    var container = document.getElementById(designationContainerID);
    var div = document.createElement("div");
    div.classList.add("form-group");
    var id = "dItemInEditDep" + designation_id_count;
    //div.setAttribute("id", id);
    designation_id_count++;

    var label_element = document.createElement("label");
    label_element.classList.add("col-sm-3");
    label_element.classList.add("control-label");


    var span = document.createElement("span");
    span.classList.add("required");
    span.setAttribute("aria-required", "true");
    span.innerText = "*";


    label_element.appendChild(span);
    label_element.innerText = "Add Designations";

    div.appendChild(label_element);


    var child_div = document.createElement("div");
    child_div.classList.add("col-sm-5");

    var input_child = document.createElement("input");
    input_child.setAttribute("type", "text");
    input_child.name = "designations[]";
    input_child.classList.add("form-control");
    input_child.setAttribute("placeholder", "Enter Your Designations");

    child_div.appendChild(input_child);

    div.appendChild(child_div);

    child_div = document.createElement("div");
    child_div.classList.add("col-sm-2");

    var strong_child = document.createElement("strong");
    var a_child = document.createElement("a");
    a_child.setAttribute("href", "javascript:void(0);");

    a_child.classList.add("remCF");
    a_child.innerHTML = "<i class='fa fa - times'></i>&nbsp;Remove";

    a_child.setAttribute("onclick", `RemoveDsgFromContainer(this, "${designationContainerID}")`);
    //alert(id);
    strong_child.appendChild(a_child);
    child_div.appendChild(strong_child);
    div.appendChild(child_div);
    container.appendChild(div);
}



function RemoveDsgFromContainer(div_element, containerID) {
    var container = document.getElementById(containerID);
    var element = div_element.parentElement;
    while (element.className != "form-group") {
        element = element.parentElement;
    }
    if (element.className == "form-group") {
        container.removeChild(element);
    }

    console.log(element.className);
}




function WorkingDaysSavedDiv(saved) {
    if (saved == true) {
        var divElement = getElementById("WorkingdaysSavedId");

        divElement.style.display = "block"
        setTimeout(function () {
            divElement.style.display = "none";
        }, 3000);
    }
}




function GetDesignations(departmentList) {
    var val = departmentList.options[departmentList.selectedIndex].value;


    if (val == "") {
        var option = $('<option></option>').attr("value", "").text("Select Designation");
        $("#designationSelectList").empty().append(option);
    }
    else {

        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {

                var response = this.responseText;
                var json_obj = JSON.parse(response);


                var option = $('<option></option>').attr("value", "").text("Select Designation");
                $("#designationSelectList").empty().append(option);

                for (i = 0; i < json_obj.length; i++) {
                    option = $('<option></option>').attr("value", `${json_obj[i].id}`).text(`${json_obj[i].name}`);
                    $("#designationSelectList").append(option);
                }
            }
        };
        xhttp.open("GET", "https://localhost:44303/" + `home/designations/${val}`, true);
        xhttp.send();
    }
}




function AddMoreEducationDetailsRow() {
    if ($("#EducationDetailsTable tbody").children("tr").length < 5) {
        var SlNo = $("#EducationDetailsTable tbody").children("tr").length;
        $("#EducationDetailsTable tbody").append(
            "<tr>" +
            "<td>" +
            `<div class="mt-auto">${SlNo + 1}</div>` +
            "</td>" +
            "<td>" +
            '<div class= "form-group">' +
            '<label class="control-label">Qualification<span class="required" aria-required="true">*</span></label>' +
            "<div>" +
            '<input type="text" class="form-control" placeholder="Enter Qualification">' +
            "</div>" +
            "</div>" +
            '<div class="form-group">' +
            '<label class="control-label">Passing Year<span class="required" aria-required="true">*</span></label>' +
            "<div>" +
            '<input type="text" class="form-control" placeholder="Enter Passing Year">' +
            "</div>" +
            "</div>" +
            "</td>" +
            "<td>" +
            '<div class="form-group">' +
            '<label class="control-label">Subject <span class="required" aria-required="true">*</span></label>' +
            "<div>" +
            '<input type="text" class="form-control" placeholder="Enter Subject">' +
            "</div>" +
            "</div>" +
            '<div class="form-group">' +
            '<label class="control-label">Grade.Result <span class="required" aria-required="true">*</span></label>' +
            "<div>" +
            '<input type="text" class="form-control" placeholder="Enter Grade">' +
            "</div>" +
            "</div>" +
            "</td>" +
            "<td>" +
            '<div class="form-group">' +
            '<label class="control-label">Institute/University <span class="required" aria-required="true">*</span></label>' +
            "<div>" +
            '<input type="text" class="form-control" placeholder="Enter Institute">' +
            "</div>" +
            "</div>" +
            "<div>" +
            '<button class="btn btn-danger" onclick="RemoveEducationDetailsRow(this)" style="margin-top:30px;">Remove</button>' +
            "</div>" +
            "</td>" +
            "</tr>"
        );
    }
}




function AddMoreExperienceDetailsRow() {
    if ($("#ExperienceDetailsTable tbody").children("tr").length < 5) {
        var SlNo = $("#ExperienceDetailsTable tbody").children("tr").length;
        $("#ExperienceDetailsTable tbody").append(
            "<tr>" +
            "<td>" +
            `<div class="mt-auto">${SlNo + 1}</div>` +
                "</td>" +
                "<td>" +
                    '<div class="form-group">' +
                        '<label class="control-label">Company Name<span class="required" aria-required="true">*</span></label>' +
                        "<div>" +
                            '<input type="text" class="form-control">' +
                                "</div>" +
                        "</div>" +

                        '<div class="form-group">' + 
                            '<label class="control-label">Duration(From)<span class="required" aria-required="true">*</span></label>' +
                            "<div>" +
                                '<input type="date" class="form-control" />' +
                            "</div>" +

                        "</div>" +
                        "</td>" +
                    "<td>" +
                        '<div class="form-group">' +
                            '<label class="control-label">Company Address <span class="required" aria-required="true">*</span></label>' +
                            "<div>" + 
                                '<input type="text" class="form-control">' +
                                "</div>" +
                            "</div>" +

                            '<div class="form-group">' +
                                '<label class="control-label">Duration(to)<span class="required" aria-required="true">*</span></label>' +
                                "<div>" +
                                    '<input type="date" class="form-control" />' +
                                "</div>" +

                            "</div>" +
                        "</td>" +
                        "<td>" +
                            '<div class="form-group">' +
                                '<label class="control-label">Role/Responsibility <span class="required" aria-required="true">*</span></label>' +
                                "<div>" +
                                    '<input type="text" class="form-control">' +
                                "</div>" +
                                "</div>" +
                                "<div>" +
                                    '<button class="btn btn-danger" onclick="RemoveExperienceDetailsRow(this)" style="margin-top:30px;">Remove</button>' +
                                "</div>" +
                        "</td>" +
                    "</tr>"
        );
    }
}





function RemoveEducationDetailsRow(btn_control) {
    $(btn_control).parents("tr").remove();
}


function RemoveExperienceDetailsRow(btn_control) {
    $(btn_control).parents("tr").remove();
}




function openDialog() {
    document.getElementById('UploadPhotoInput').click();
}