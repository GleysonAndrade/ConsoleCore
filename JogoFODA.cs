using System;
using GameTop.Lib;
using GameTOP.Interface;

namespace GameTOP
{
    public  class JogoFODA
    {
    private readonly IJogador _jogadorA;
    private readonly IJogador _jogadorB;

    public JogoFODA(IJogador jogadorA, IJogador jogadorB)
    {
        _jogadorA = jogadorA;
        _jogadorB = jogadorB;
    }

        public JogoFODA(Jogador1 jogador1, Jogador2 jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }

        public Jogador1 Jogador1 { get; }
        public Jogador2 Jogador2 { get; }

        public void IniciarJogo()
     {
        Console.Write(_jogadorA.Corre());
        Console.Write(_jogadorA.Chuta());
        Console.Write(_jogadorA.Passe());
        //
        Console.WriteLine("\n Próximo Jogador \n");
        //
        Console.Write(_jogadorB.Corre());
        Console.Write(_jogadorB.Chuta());
        Console.Write(_jogadorB.Passe());
     }
    }
}