$(document).ready(() => {


    $('#frmRegistrarAdministrador').bootstrapValidator({
        fields: {
            txtNombre: {
                validators: {
                    notEmpty: {
                        message: 'El nombre del nuevo administrador es obligatorio'
                    },
                    stringLength: {
                        message: 'Debe tener entre 4 y 32 caracteres',
                        min: 4,
                        max: 32,
                        trim: true
                    }
                }
            },
            txtApellidos: {
                validators: {
                    notEmpty: {
                        message: 'Los apellidos son requeridos'
                    },
                    stringLength: {
                        message: 'Debe tener entre 4 y 32 caracteres',
                        min: 4,
                        max: 32,
                        trim: true
                    }
                }
            },
            txtDireccion: {
                validators: {
                    notEmpty: {
                        message: 'La dirección (domicilio) es un dato requerido'
                    },
                    stringLength: {
                        message: 'Ingresa su dirección correctamente',
                        min: 8,
                        max:64,
                        trim: true
                    }
                }
            },
            txtTelefono: {
                validators: {
                    notEmpty: {
                        message: 'El teléfono es un dato requerido'
                    },
                    stringLength: {
                        message: 'Ingresa correctamente el número telefónico (10 carácteres mínimo)',
                        min: 10,
                        max: 16,
                        trim: true
                    },
                    numeric: {
                        message: 'Ingresa un número telefónico válido'
                    }

                }
            },
            txtEmail: {
                validators: {
                    notEmpty: {
                        message: 'El email es un dato requerido'
                    },
                    stringLength: {
                        message: 'Ingresa correctamente tu email',
                        min: 8,
                        max: 64,
                        trim: true
                    },
                    emailAddress: {
                        message: 'Ingresa tu Email correctamente'
                    }
                }
            },
            txtClave: {
                validators: {
                    notEmpty: {
                        message: 'La clave es un dato obligatorio (no la compartas con nadie)'
                    },
                    stringLength: {
                        message: 'Tu clave debe contener entre 4 y 16 caracteres',
                        min: 4,
                        max: 16,
                        trim: true
                    }
                }
            }

        } //Fields
    }); //Validator
});