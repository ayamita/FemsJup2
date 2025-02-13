﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Fems_Jup.BO
{
    public class UsuarioAdmin
    {
        private int id;
        private bool resp;
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private string foto;
        private string direccion;
        private string telefono;
        private string pais;
        private string estado;
        private string estatus;
        private string tusuario;
        private string municipio;
        private string correo;
        private string contrasenia;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string ApellidoP
        {
            get
            {
                return apellidoP;
            }

            set
            {
                apellidoP = value;
            }
        }

        public string ApellidoM
        {
            get
            {
                return apellidoM;
            }

            set
            {
                apellidoM = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Municipio
        {
            get
            {
                return municipio;
            }

            set
            {
                municipio = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }

            set
            {
                contrasenia = value;
            }
        }

        public string Foto { get => foto; set => foto = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public string Tusuario { get => tusuario; set => tusuario = value; }
        public bool Resp { get => resp; set => resp = value; }

        public Image RedimencionarImagen(Image Imgoriginal, int Altoimg)

        {

            var Radio = (double)Altoimg / Imgoriginal.Height;//diferencia entre la imagenes

            var NuevoAncho = (int)(Imgoriginal.Width * Radio);

            var NuevoAlto = (int)(Imgoriginal.Height * Radio);

            var ImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);

            //creo archivo apartir del bitmap con las nuevas dimensiones

            var g = Graphics.FromImage(ImagenRedimencionada);

            g.DrawImage(Imgoriginal, 0, 0, NuevoAncho, NuevoAlto);

            return ImagenRedimencionada;

        }

    }
}