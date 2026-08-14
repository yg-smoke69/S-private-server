using System;
using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CBF")]
public abstract class UIVariableBindBool : UIVariableBind
{
	[Token(Token = "0x2000CC0")]
	public enum BooleanLogic
	{
		[Token(Token = "0x400679F")]
		And,
		[Token(Token = "0x40067A0")]
		Or
	}

	[Token(Token = "0x2000CC1")]
	public enum CompareModeEnum
	{
		[Token(Token = "0x40067A2")]
		Less,
		[Token(Token = "0x40067A3")]
		LessEqual,
		[Token(Token = "0x40067A4")]
		Equal,
		[Token(Token = "0x40067A5")]
		Great,
		[Token(Token = "0x40067A6")]
		GreatEqual
	}

	[Serializable]
	[Token(Token = "0x2000CC2")]
	private class OneVar
	{
		[Token(Token = "0x40067A7")]
		[FieldOffset(Offset = "0x8")]
		private string variableName;

		[Token(Token = "0x40067A8")]
		[FieldOffset(Offset = "0xC")]
		private CompareModeEnum compareMode;

		[Token(Token = "0x40067A9")]
		[FieldOffset(Offset = "0x10")]
		private int referenceInt;

		[Token(Token = "0x40067AA")]
		[FieldOffset(Offset = "0x14")]
		private float referenceFloat;

		[Token(Token = "0x40067AB")]
		[FieldOffset(Offset = "0x18")]
		private string referenceVariableName;

		[Token(Token = "0x40067AC")]
		[FieldOffset(Offset = "0x1C")]
		private bool reverse;

		[Token(Token = "0x40067AD")]
		[FieldOffset(Offset = "0x20")]
		private UIVariable ownerVar;

		[Token(Token = "0x40067AE")]
		[FieldOffset(Offset = "0x24")]
		private UIVariable referenceVar;

		[Token(Token = "0x17000819")]
		public UIVariable ReferenceVar
		{
			[Token(Token = "0x6006127")]
			[Address(RVA = "0x315EBFC", Offset = "0x315EBFC", VA = "0x315EBFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006128")]
			[Address(RVA = "0x315EBF4", Offset = "0x315EBF4", VA = "0x315EBF4")]
			set
			{
			}
		}

		[Token(Token = "0x6006126")]
		[Address(RVA = "0x315EE34", Offset = "0x315EE34", VA = "0x315EE34")]
		public OneVar()
		{
		}

		[Token(Token = "0x6006129")]
		[Address(RVA = "0x315EBEC", Offset = "0x315EBEC", VA = "0x315EBEC")]
		public string GetRefVariableName()
		{
			return null;
		}

		[Token(Token = "0x600612A")]
		[Address(RVA = "0x315EBDC", Offset = "0x315EBDC", VA = "0x315EBDC")]
		public string GetVariableName()
		{
			return null;
		}

		[Token(Token = "0x600612B")]
		[Address(RVA = "0x315EBD4", Offset = "0x315EBD4", VA = "0x315EBD4")]
		public UIVariable GetVariable()
		{
			return null;
		}

		[Token(Token = "0x600612C")]
		[Address(RVA = "0x315EBE4", Offset = "0x315EBE4", VA = "0x315EBE4")]
		public void SetVariable(UIVariable v)
		{
		}

		[Token(Token = "0x600612D")]
		[Address(RVA = "0x315E5D8", Offset = "0x315E5D8", VA = "0x315E5D8")]
		public bool GetValue()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400679B")]
	[FieldOffset(Offset = "0x1C")]
	private BooleanLogic booleanLogic;

	[Token(Token = "0x400679C")]
	[FieldOffset(Offset = "0x20")]
	private OneVar[] variables;

	[Token(Token = "0x400679D")]
	[FieldOffset(Offset = "0x24")]
	private bool reverse;

	[Token(Token = "0x600611F")]
	[Address(RVA = "0x315E1A4", Offset = "0x315E1A4", VA = "0x315E1A4")]
	protected UIVariableBindBool()
	{
	}

	[Token(Token = "0x6006120")]
	[Address(RVA = "0x315E4D0", Offset = "0x315E4D0", VA = "0x315E4D0")]
	public new UIVariable FindVariable(string name)
	{
		return null;
	}

	[Token(Token = "0x6006121")]
	[Address(RVA = "0x315E4A4", Offset = "0x315E4A4", VA = "0x315E4A4")]
	protected bool GetResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6006122")]
	[Address(RVA = "0x315E4D4", Offset = "0x315E4D4", VA = "0x315E4D4")]
	private bool GetResultInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x6006123")]
	protected abstract void OnValueChanged();

	[Token(Token = "0x6006124")]
	[Address(RVA = "0x315E880", Offset = "0x315E880", VA = "0x315E880", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x6006125")]
	[Address(RVA = "0x315EC04", Offset = "0x315EC04", VA = "0x315EC04", Slot = "7")]
	protected override void UnbindVariables()
	{
	}
}
