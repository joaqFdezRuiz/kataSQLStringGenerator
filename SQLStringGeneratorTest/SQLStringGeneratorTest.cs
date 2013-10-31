﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SQLStringGeneratorTest
{
  [TestFixture]
  public class SQLStringGeneratorTest
  {
    [Test]
    public void Select_Sobre_Un_Campo() {
      SQLStringGenerator.Class1 class1 = new SQLStringGenerator.Class1();
      Assert.AreEqual("SELECT a FROM x", class1.GetSentence("x", new string[] { "a" }));
      Assert.AreEqual("SELECT b FROM x", class1.GetSentence("x", new string[] { "b" }));
      Assert.AreEqual("SELECT c FROM y", class1.GetSentence("y", new string[] { "c" }));
    }

    [Test]
    public void Select_Sobre_Dos_Campos()
    {
      SQLStringGenerator.Class1 class1 = new SQLStringGenerator.Class1();
      Assert.AreEqual("SELECT a,b FROM x", class1.GetSentence("x", new string[] { "a", "b" }));
      Assert.AreEqual("SELECT b,c FROM x", class1.GetSentence("x", new string[] { "b", "c" }));
      Assert.AreEqual("SELECT c,d FROM y", class1.GetSentence("y", new string[] { "c", "d" }));
    }
  }
}
