<script>
    $(document).ready(function () {
        $('#FoodID').change(function () {
            //$('#Food_UnitPrice').val($(this).val());

            $.ajax({
                url: '@Url.Action("GetByFoodID", "Order")',
                type: "POST",
                data: { "ID": foodid },
                "success": function (data) {
                    if (data != null) {
                        var vdata = data;
                        $("#Food_UnitPrice").val(vdata[0].UnitPrice);

                    }
                }
            });
        });
    });
    </script>