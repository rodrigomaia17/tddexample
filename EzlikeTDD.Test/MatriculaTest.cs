using System;
using EzLikeTDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EzlikeTDD.Test
{
    [TestClass]
    public class MatriculaTest
    {
        [TestMethod]
        public void ConsigoMatricularUmAluno()
        {
            //Preparar
            var aluno = new Aluno();
            var turma = new Turma();
            turma.Discisplina = new Discisplina();

            //realizar
            turma.Matricula(aluno);

            //Testar
            Assert.IsTrue(turma.Alunos.Contains(aluno));
        }

        [TestMethod]
        [ExpectedException(typeof(MatriculaSemPreRequisitoException),AllowDerivedTypes = true)]
        public void NaoConsigoMatricularUmAlunoQueNaoTiverFeitoPreRequisitosDaMateria()
        {
            //Preparar

            var alunoMegale = new Aluno();
            var matematicaDois = new Discisplina();
            var matematicaUm = new Discisplina();
            matematicaDois.PreRequisitos.Add(matematicaUm);

            var turmaA = new Turma();
            turmaA.Discisplina = matematicaDois;
            //Realizar

            turmaA.Matricula(alunoMegale);

            //Test
        }
    }
}
