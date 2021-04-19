$(document).ready(function () {
    $("#gvEjercicios").prepend($("<thead></thead>").append($("#gvEjercicios").find("tr:first"))).dataTable();
    $('#gvEjercicios').DataTable();

    /*
    $('#frmDatos').bootstrapValidator(
    {
        fields:
        {
            TextBox0: //No cotizacion
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'El ID de la cotizacion es obligatorio'
                    },
                    stringLength:
                    {
                        message: 'Debe tener un mínimo de 5 dígitos, máximo 8',
                        min: 5,
                        max: 8,
                        trim: true
                    }
                }
            },
            TextBox1: //Agencia
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'El nombre de la agencia es obligatorio'
                    },
                    stringLength:
                    {
                        message: 'Debe tener un mínimo de 5 carácteres',
                        min: 5,
                        max: 64,
                        trim: true
                    }
                }
            },
            TextBox2: // Fecha cot.
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'La fecha de registro es un dato obligatorio'
                    },
                    stringLength:
                    {
                        message: 'Debe tener un formato de dd/mm/aaaa',
                        min: 10,
                        max: 10,
                        trim: true
                    }
                }
            },
            TextBox3: // Nombre
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'Complete este campo'
                    },
                    stringLength:
                    {
                        message: 'El nombre debe tener al menos 6 carácteres',
                        min: 6,
                        max: 64,
                        trim: true
                    }
                }
            },
            TextBox4: // RFC
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'Ingrese su RFC correctamente'
                    },
                    stringLength:
                    {
                        message: 'El RFC debe contener 13 caracteres',
                        min: 13,
                        max: 13,
                        trim: true
                    }
                }
            },
            TextBox5: // Telefono
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'Complete este campo'
                    },
                    stringLength:
                    {
                        message: 'El número de teléfono debe tener 10 dígitos',
                        min: 10,
                        max: 10,
                        trim: true
                    }
                }
            },
            TextBox6: // Marca
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'Complete este campo'
                    },
                    stringLength:
                    {
                        message: 'El nombre de la marca debe tener un mínimo de 5 dígitos',
                        min: 5,
                        max: 32,
                        trim: true
                    }
                }
            },
            TextBox7: // Modelo
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'Complete este campo'
                    },
                    stringLength:
                    {
                        message: 'El modelo debe tener un minimo de 2 carácteres',
                        min: 2,
                        max: 16,
                        trim: true
                    }
                }
            },
            TextBox8: // No. Serie
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'Complete este campo'
                    },
                    stringLength:
                    {
                        message: 'El número de serie debe contener al menos 3 carácteres',
                        min: 3,
                        max: 32,
                        trim: true
                    }
                }
            },
            TextBox9: // Motor
            {
                validators:
                {
                    notEmpty:
                    {
                        message: 'Complete este campo'
                    },
                    stringLength:
                    {
                        message: 'Debe tener un minimo de 5 carácteres',
                        min: 5,
                        max: 32,
                        trim: true
                    }
                }
            },

        } //fields

    }) //BsV */

}); //Ready