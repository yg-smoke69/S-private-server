using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace PrefabEvolution;

[Serializable]
[Token(Token = "0x2003BA8")]
public class ExposedProperty : BaseExposedData
{
	[Token(Token = "0x2003BA9")]
	public class PropertyInvocationChain
	{
		[Token(Token = "0x2003BAA")]
		public class InvokeInfo
		{
			[Token(Token = "0x4019677")]
			[FieldOffset(Offset = "0x8")]
			public MemberInfo member;

			[Token(Token = "0x4019678")]
			[FieldOffset(Offset = "0xC")]
			public int index;

			[Token(Token = "0x4019679")]
			[FieldOffset(Offset = "0x10")]
			public object tempTarget;

			[Token(Token = "0x401967A")]
			[FieldOffset(Offset = "0x14")]
			public Type valueType;

			[Token(Token = "0x6017CF8")]
			[Address(RVA = "0x1E2BD14", Offset = "0x1E2BD14", VA = "0x1E2BD14")]
			public InvokeInfo()
			{
			}

			[Token(Token = "0x6017CF9")]
			[Address(RVA = "0x1E2BCA8", Offset = "0x1E2BCA8", VA = "0x1E2BCA8")]
			public object GetValue(object target)
			{
				return null;
			}

			[Token(Token = "0x6017CFA")]
			[Address(RVA = "0x1E2BCC0", Offset = "0x1E2BCC0", VA = "0x1E2BCC0")]
			public void SetValue(object target, object value)
			{
			}

			[Token(Token = "0x6017CFB")]
			[Address(RVA = "0x1E2BCEC", Offset = "0x1E2BCEC", VA = "0x1E2BCEC")]
			public void SetValue(object value)
			{
			}
		}

		[Token(Token = "0x2003BAB")]
		private sealed class _003CgetField_003Ec__AnonStorey0
		{
			[Token(Token = "0x401967B")]
			[FieldOffset(Offset = "0x8")]
			internal string field;

			[Token(Token = "0x6017CFC")]
			[Address(RVA = "0x1E2C4D0", Offset = "0x1E2C4D0", VA = "0x1E2C4D0")]
			public _003CgetField_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6017CFD")]
			[Address(RVA = "0x1E2C4D8", Offset = "0x1E2C4D8", VA = "0x1E2C4D8")]
			internal bool _003C_003Em__0(MemberInfo m)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4019674")]
		[FieldOffset(Offset = "0x8")]
		public object root;

		[Token(Token = "0x4019675")]
		[FieldOffset(Offset = "0xC")]
		public string path;

		[Token(Token = "0x4019676")]
		[FieldOffset(Offset = "0x10")]
		public InvokeInfo[] members;

		[Token(Token = "0x170018B8")]
		public object value
		{
			[Token(Token = "0x6017CF0")]
			[Address(RVA = "0x1E2AED4", Offset = "0x1E2AED4", VA = "0x1E2AED4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017CF1")]
			[Address(RVA = "0x1E2AF94", Offset = "0x1E2AF94", VA = "0x1E2AF94")]
			set
			{
			}
		}

		[Token(Token = "0x170018B9")]
		public bool isValid
		{
			[Token(Token = "0x6017CF2")]
			[Address(RVA = "0x1E2AEC4", Offset = "0x1E2AEC4", VA = "0x1E2AEC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6017CEF")]
		[Address(RVA = "0x1E2A89C", Offset = "0x1E2A89C", VA = "0x1E2A89C")]
		public PropertyInvocationChain(object root, string path)
		{
		}

		[Token(Token = "0x6017CF3")]
		[Address(RVA = "0x1E2B238", Offset = "0x1E2B238", VA = "0x1E2B238")]
		internal static object GetInstance(object obj, string path, out InvokeInfo[] members)
		{
			return null;
		}

		[Token(Token = "0x6017CF4")]
		[Address(RVA = "0x1E2C0D4", Offset = "0x1E2C0D4", VA = "0x1E2C0D4")]
		private static object GetMemberValue(object target, MemberInfo member, int index = -1)
		{
			return null;
		}

		[Token(Token = "0x6017CF5")]
		[Address(RVA = "0x1E2C2AC", Offset = "0x1E2C2AC", VA = "0x1E2C2AC")]
		private static void setValue(object target, MemberInfo member, object value, int index = -1)
		{
		}

		[Token(Token = "0x6017CF6")]
		[Address(RVA = "0x1E2BA44", Offset = "0x1E2BA44", VA = "0x1E2BA44")]
		public static string GetValidFieldName(ref object obj, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x6017CF7")]
		[Address(RVA = "0x1E2BD24", Offset = "0x1E2BD24", VA = "0x1E2BD24")]
		private static object getField(object obj, string field, out MemberInfo member, int index = -1)
		{
			return null;
		}
	}

	[Token(Token = "0x4019671")]
	[FieldOffset(Offset = "0x1C")]
	public Object Target;

	[Token(Token = "0x4019672")]
	[FieldOffset(Offset = "0x20")]
	public string PropertyPath;

	[Token(Token = "0x4019673")]
	[FieldOffset(Offset = "0x24")]
	private PropertyInvocationChain _invocationChain;

	[Token(Token = "0x170018B5")]
	private PropertyInvocationChain invocationChain
	{
		[Token(Token = "0x6017CEB")]
		[Address(RVA = "0x1E2A708", Offset = "0x1E2A708", VA = "0x1E2A708")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018B6")]
	public bool IsValid
	{
		[Token(Token = "0x6017CEC")]
		[Address(RVA = "0x1E2AE94", Offset = "0x1E2AE94", VA = "0x1E2AE94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018B7")]
	public object Value
	{
		[Token(Token = "0x6017CED")]
		[Address(RVA = "0x1E2A8D4", Offset = "0x1E2A8D4", VA = "0x1E2A8D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017CEE")]
		[Address(RVA = "0x1E2AB7C", Offset = "0x1E2AB7C", VA = "0x1E2AB7C")]
		set
		{
		}
	}

	[Token(Token = "0x6017CE8")]
	[Address(RVA = "0x1E2A5E4", Offset = "0x1E2A5E4", VA = "0x1E2A5E4")]
	public ExposedProperty()
	{
	}

	[Token(Token = "0x6017CE9")]
	[Address(RVA = "0x1E2A5E8", Offset = "0x1E2A5E8", VA = "0x1E2A5E8", Slot = "8")]
	public override BaseExposedData Clone()
	{
		return null;
	}

	[Token(Token = "0x6017CEA")]
	[Address(RVA = "0x1E2A6FC", Offset = "0x1E2A6FC", VA = "0x1E2A6FC", Slot = "7")]
	public override void OnAfterDeserialize()
	{
	}
}
