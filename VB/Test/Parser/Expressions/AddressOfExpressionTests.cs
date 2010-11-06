﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.IO;
using NUnit.Framework;
using ICSharpCode.NRefactory.VB.Parser;
using ICSharpCode.NRefactory.VB.Dom;

namespace ICSharpCode.NRefactory.VB.Tests.Dom
{
	[TestFixture]
	public class AddressOfExpressionTests
	{
		[Test]
		public void SimpleAddressOfExpressionTest()
		{
			AddressOfExpression ae = ParseUtilVBNet.ParseExpression<AddressOfExpression>("AddressOf t");
			Assert.IsNotNull(ae);
			Assert.IsInstanceOf(typeof(IdentifierExpression), ae.Expression);
			Assert.AreEqual("t", ((IdentifierExpression)ae.Expression).Identifier, "t");
		}
		
		[Test]
		public void GenericAddressOfExpressionTest()
		{
			AddressOfExpression ae = ParseUtilVBNet.ParseExpression<AddressOfExpression>("AddressOf t(Of X)");
			Assert.IsNotNull(ae);
			Assert.IsInstanceOf(typeof(IdentifierExpression), ae.Expression);
			Assert.AreEqual("t", ((IdentifierExpression)ae.Expression).Identifier, "t");
			Assert.AreEqual(1, ((IdentifierExpression)ae.Expression).TypeArguments.Count);
			Assert.AreEqual("X", ((IdentifierExpression)ae.Expression).TypeArguments[0].Type);
		}
		
		[Test]
		public void MemberReferenceAddressOfExpressionTest()
		{
			AddressOfExpression ae = ParseUtilVBNet.ParseExpression<AddressOfExpression>("AddressOf Me.t(Of X)");
			Assert.IsNotNull(ae);
			Assert.IsInstanceOf(typeof(MemberReferenceExpression), ae.Expression);
			Assert.AreEqual("t", ((MemberReferenceExpression)ae.Expression).MemberName, "t");
			Assert.IsInstanceOf(typeof(ThisReferenceExpression), ((MemberReferenceExpression)ae.Expression).TargetObject);
		}
	}
}
