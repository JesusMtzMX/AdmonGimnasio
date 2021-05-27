$(document).ready(() => {

    $('#form1').bootstrapValidator({
        fields: {
            txtNombre: {
                validators: {
                    notEmpty: {
                        message: 'Tu nombre es obligatorio para el registro'
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
                        message: 'Tus apellidos son requeridos para el registro'
                    },
                    stringLength: {
                        message: 'Debe tener entre 4 y 32 caracteres',
                        min: 4,
                        max: 32,
                        trim: true
                    }
                }
            },
            txtEdad: {
                validators: {
                    notEmpty: {
                        message: 'La edad es un dato requerido'
                    },
                    stringLength: {
                        message: 'Ingresa tu edad correctamente',
                        min: 1,
                        max: 2,
                        trim: true
                    },
                    numeric: {
                        message: 'Ingresa una edad en años válida'
                    }
                }
            },
            txtPeso: {
                validators: {
                    notEmpty: {
                        message: 'El peso es un dato requerido'
                    },
                    stringLength: {
                        message: 'Ingresa correctamente tu peso (en kilogramos)',
                        min: 10,
                        max: 16,
                        trim: true
                    },
                    numeric: {
                        message: 'Ingresa un peso en kg válido'
                    }

                }
            },            
            txtEstatura: {
                validators: {
                    notEmpty: {
                        message: 'La estatura es un dato requerido'
                    },
                    stringLength: {
                        message: 'Ingresa correctamente tu estatura (en centímetros)',
                        min: 1,
                        max: 2,
                        trim: true
                    },
                    numeric: {
                        message: 'Ingresa una estatura válida'
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