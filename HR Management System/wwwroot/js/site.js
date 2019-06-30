// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

        $(document).ready(function () {
            var maxAppend = 0;
            $("#add_more").click(function () {
                if (maxAppend >= 9) {
                    alert("Maximum 10 File is allowed");
                } else {
                    var add_new = $('<div class="form-group">\n\
                    <label for="field-1" class="col-sm-3 control-label">Add Designations <span class="required"> *</span></label>\n\
                        <div class="col-sm-5">\n\<input type="text" name="designations[]" value="" class="form-control" placeholder="Enter Your Designations"/>\n\
        </div>\n\
        <div class="col-sm-2">\n\
        <strong><a href="javascript:void(0);" class="remCF"><i class="fa fa-times"></i>&nbsp;Remove</a></strong>\n\
        </div>');
                    maxAppend++;
                    $("#add_new").append(add_new);
                }
            });

            $("#add_new").on('click', '.remCF', function () {
                $(this).parent().parent().parent().remove();
            });
        });