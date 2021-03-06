﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Construtor Padrao revisado
/// Palavra Chave this
/// Nao podemos usar this em membros statics
/// Construtores encadeados
/// 
/// </summary>
namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;

        public string name;

        public string driverName;

        /// <summary>
        /// Construtor padrao explicito porque existe um construtor personalizado
        /// Encadeamento do Construtor
        /// </summary>
        public Motorcycle()
        {
            Console.WriteLine("In default ctor");
        }

        /// <summary>
        /// Logica redundante construtor
        /// Construtor encadeado 
        /// </summary>
        /// <param name="intensity"></param>
        public Motorcycle(int intensity) : this(intensity, "")
        {
            Console.WriteLine("In default ctor");
        }

        public Motorcycle(string name) : this(0, name) { }
 
        /// <summary>
        /// Construtor personalizado com dois parametros
        /// Construtor master
        /// </summary>
        /// <param name="intensity"></param>
        /// <param name="name"></param>
        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
            driverName = name;
        }

        /**
        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
        } **/

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaaeeeewwww");
            }

        }

        public void setDriverName(string name)
        {
            // atribui a variavel name para si mesma
            // quando chamado retorna vazio
            // name = name;
            
            //nao necessario que a variavel de escopo global e diferente da local
            driverName = name;

            // usando a palavra chave this para eleminar ambiguidades de escopo da classe
            // variaveis com mesmo nome 
            // refere-se aos parametros da propria classe
            this.name = name;

        }

    }
}
