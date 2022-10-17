$(document).ready(function () {
    $('#students').dataTable({
        "serverSide": true,
        "filter": true,
        "ajax": {
            "url": "/api/Student",
            "type": "POST",
            "datatype":"json"
        },
        "columnDefs": [{
            "targets": [0],
            "visible": false,
            "searchable":false
        }],
        "columns": [
            {"data":"id",            "name":"Id",           "autowidth":true},
            {"data":"name",          "name":"Name",         "autowidth":true},
            //{"data": "date_of_birth",  "name":"Date_of_birth","autowidth":true},
            //{"data": "year_enrolled", "name":"Year_enrolled","autowidth":true},
            {"data": "year_class",    "name": "Year_class",  "autowidth": true},

            {"data":"address",  "name":"Address",  "autowidth":true},
            {"data":"age",      "name":"Age",      "autowidth":true},
            {"data":"email",    "name":"Email",    "autowidth":true},
            //{"data":"password", "name":"Password", "autowidth":true},
            {"data": "section", "name": "Section", "autowidth": true },

            //{"data":"gpa",       "name":"GPA",       "autowidth":true},
            {"data": "phone_No",  "name":"Phone_No",  "autowidth":true},
            //{"data":"hobby",     "name":"Hobby",     "autowidth":true},
            {"data":"gender",    "name":"Gender",    "autowidth":true},
            {"data":"department","name":"Department","autowidth":true}
        ]
    
    });
})