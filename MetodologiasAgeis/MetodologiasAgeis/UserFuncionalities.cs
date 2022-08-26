using System;
using System.Collections.Generic;

namespace MetodologiasAgeis
{
    public class UserFuncionalities
    {
        List<User> userList = new List<User>();

        public void IncludeUser()
        {
            try
            {
                Console.WriteLine("Insira o nome do usuario");
                string userName = Console.ReadLine();
                Console.WriteLine("Insira a idade do usuario");
                int userAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o sexo do cliente M-masculino F-Menino");
                char userSex = Convert.ToChar(Console.ReadLine());
                userList.Add(new User { userName = userName, userAge = userAge, userSex = userSex });
                Console.Clear();
                Console.WriteLine("Usuario inserido com sucesso");
                Console.WriteLine("aperte qualquer tecla para prtosseguir");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex) 
            {
                Console.Clear();
                Console.WriteLine("Usuario inserido com falha,\n" + ex);
                Console.WriteLine("\n aperte qualquer tecla para prtosseguir \n");
                Console.ReadKey();
            }
        }

        public void ShowUsers() 
        {
            try
            {
                if (userList.Count <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Lista de usuarios vazia");
                }
                else 
                {
                    Console.WriteLine("Lista de usuarios cadastrados");
                    for (int i = 0; i < userList.Count; i++) 
                    {
                        string userSex;
                        switch (userList[i].userSex.ToString())
                        {
                            case "M":
                                userSex = "Masculino";
                                break;
                            case "F":
                                userSex = "Feminino";
                                break;
                            default:
                                userSex = "Não cadastrado";
                                break;
                        }
                        Console.Write("Usuario: " + userList[i].userName + "\n idade: " + userList[i].userAge + "\n sexo: "+ userSex+"\n");
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Erro  ao listar usuarios, " + ex);
            }
        }
    }
}
