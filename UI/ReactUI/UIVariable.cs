using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ReactUI;

[Serializable]
[Token(Token = "0x2000CBB")]
public sealed class UIVariable
{
	[Token(Token = "0x4006785")]
	[FieldOffset(Offset = "0x8")]
	private string name;

	[Token(Token = "0x4006786")]
	[FieldOffset(Offset = "0xC")]
	private UIVariableType type;

	[Token(Token = "0x4006787")]
	[FieldOffset(Offset = "0x10")]
	private bool booleanValue;

	[Token(Token = "0x4006788")]
	[FieldOffset(Offset = "0x18")]
	private long integerValue;

	[Token(Token = "0x4006789")]
	[FieldOffset(Offset = "0x20")]
	private float floatValue;

	[Token(Token = "0x400678A")]
	[FieldOffset(Offset = "0x24")]
	private string stringValue;

	[Token(Token = "0x400678B")]
	[FieldOffset(Offset = "0x28")]
	private IList arrayValue;

	[Token(Token = "0x400678C")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIVariableBind> binderList;

	[Token(Token = "0x400678D")]
	[FieldOffset(Offset = "0x30")]
	private Action actionOnValueChanged;

	[Token(Token = "0x400678E")]
	[FieldOffset(Offset = "0x34")]
	private Action actionOnValueInit;

	[Token(Token = "0x400678F")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<UIVariableBind> _2004_2055;

	[Token(Token = "0x4006790")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<UIVariableBind> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000814")]
	public string Name
	{
		[Token(Token = "0x60060E8")]
		[Address(RVA = "0x315ABA0", Offset = "0x315ABA0", VA = "0x315ABA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000815")]
	public UIVariableType Type
	{
		[Token(Token = "0x60060E9")]
		[Address(RVA = "0x315B9C4", Offset = "0x315B9C4", VA = "0x315B9C4")]
		get
		{
			return default(UIVariableType);
		}
	}

	[Token(Token = "0x17000816")]
	public object ValueObject
	{
		[Token(Token = "0x60060EA")]
		[Address(RVA = "0x315CE54", Offset = "0x315CE54", VA = "0x315CE54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000817")]
	public ICollection<UIVariableBind> Binds
	{
		[Token(Token = "0x60060EB")]
		[Address(RVA = "0x315CF4C", Offset = "0x315CF4C", VA = "0x315CF4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000004")]
	public event Action OnValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x60060EC")]
		[Address(RVA = "0x315ADA8", Offset = "0x315ADA8", VA = "0x315ADA8")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x60060ED")]
		[Address(RVA = "0x315B05C", Offset = "0x315B05C", VA = "0x315B05C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action OnValueInitialized
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x60060EE")]
		[Address(RVA = "0x315AE94", Offset = "0x315AE94", VA = "0x315AE94")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x60060EF")]
		[Address(RVA = "0x315B148", Offset = "0x315B148", VA = "0x315B148")]
		remove
		{
		}
	}

	[Token(Token = "0x60060E7")]
	[Address(RVA = "0x315CDC8", Offset = "0x315CDC8", VA = "0x315CDC8")]
	public UIVariable()
	{
	}

	[Token(Token = "0x60060F0")]
	[Address(RVA = "0x315B9CC", Offset = "0x315B9CC", VA = "0x315B9CC")]
	public bool GetBoolean()
	{
		return default(bool);
	}

	[Token(Token = "0x60060F1")]
	[Address(RVA = "0x315BD3C", Offset = "0x315BD3C", VA = "0x315BD3C")]
	public int GetInteger()
	{
		return default(int);
	}

	[Token(Token = "0x60060F2")]
	[Address(RVA = "0x315CF54", Offset = "0x315CF54", VA = "0x315CF54")]
	public long GetLongVal()
	{
		return default(long);
	}

	[Token(Token = "0x60060F3")]
	[Address(RVA = "0x315BF04", Offset = "0x315BF04", VA = "0x315BF04")]
	public float GetFloat()
	{
		return default(float);
	}

	[Token(Token = "0x60060F4")]
	[Address(RVA = "0x315C160", Offset = "0x315C160", VA = "0x315C160")]
	public string GetString()
	{
		return null;
	}

	[Token(Token = "0x60060F5")]
	[Address(RVA = "0x315CF5C", Offset = "0x315CF5C", VA = "0x315CF5C")]
	public IList GetArray()
	{
		return null;
	}

	[Token(Token = "0x60060F6")]
	[Address(RVA = "0x315CF64", Offset = "0x315CF64", VA = "0x315CF64")]
	public void InitBoolean(bool value)
	{
	}

	[Token(Token = "0x60060F7")]
	[Address(RVA = "0x315CFAC", Offset = "0x315CFAC", VA = "0x315CFAC")]
	public void InitInteger(long value)
	{
	}

	[Token(Token = "0x60060F8")]
	[Address(RVA = "0x315CFF4", Offset = "0x315CFF4", VA = "0x315CFF4")]
	public void InitFloat(float value)
	{
	}

	[Token(Token = "0x60060F9")]
	[Address(RVA = "0x315D024", Offset = "0x315D024", VA = "0x315D024")]
	public void InitString(string value)
	{
	}

	[Token(Token = "0x60060FA")]
	[Address(RVA = "0x315D0D8", Offset = "0x315D0D8", VA = "0x315D0D8")]
	public void InitArray(IList arr)
	{
	}

	[Token(Token = "0x60060FB")]
	[Address(RVA = "0x315C3D8", Offset = "0x315C3D8", VA = "0x315C3D8")]
	public void SetBoolean(bool value, bool forceSet = false)
	{
	}

	[Token(Token = "0x60060FC")]
	[Address(RVA = "0x315C414", Offset = "0x315C414", VA = "0x315C414")]
	public void SetInteger(long value, bool forceSet = false)
	{
	}

	[Token(Token = "0x60060FD")]
	[Address(RVA = "0x315C468", Offset = "0x315C468", VA = "0x315C468")]
	public void SetFloat(float value, bool forceSet = false)
	{
	}

	[Token(Token = "0x60060FE")]
	[Address(RVA = "0x315C4B4", Offset = "0x315C4B4", VA = "0x315C4B4")]
	public void SetString(string value, bool forceSet = false)
	{
	}

	[Token(Token = "0x60060FF")]
	[Address(RVA = "0x315D108", Offset = "0x315D108", VA = "0x315D108")]
	public void SetArray(IList value)
	{
	}

	[Token(Token = "0x6006100")]
	[Address(RVA = "0x315D124", Offset = "0x315D124", VA = "0x315D124")]
	public void InitValue(bool value)
	{
	}

	[Token(Token = "0x6006101")]
	[Address(RVA = "0x315D218", Offset = "0x315D218", VA = "0x315D218")]
	public void InitValue(long value)
	{
	}

	[Token(Token = "0x6006102")]
	[Address(RVA = "0x315D320", Offset = "0x315D320", VA = "0x315D320")]
	public void InitValue(float value)
	{
	}

	[Token(Token = "0x6006103")]
	[Address(RVA = "0x315D484", Offset = "0x315D484", VA = "0x315D484")]
	public void InitValue(string value)
	{
	}

	[Token(Token = "0x6006104")]
	[Address(RVA = "0x315D5E4", Offset = "0x315D5E4", VA = "0x315D5E4")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x6006105")]
	[Address(RVA = "0x315D6EC", Offset = "0x315D6EC", VA = "0x315D6EC")]
	public void SetValue(long value)
	{
	}

	[Token(Token = "0x6006106")]
	[Address(RVA = "0x315D808", Offset = "0x315D808", VA = "0x315D808")]
	public void SetValue(float value)
	{
	}

	[Token(Token = "0x6006107")]
	[Address(RVA = "0x315D980", Offset = "0x315D980", VA = "0x315D980")]
	public void SetValue(string value)
	{
	}

	[Token(Token = "0x6006108")]
	[Address(RVA = "0x315DAF4", Offset = "0x315DAF4", VA = "0x315DAF4")]
	public void AddBind(UIVariableBind bind)
	{
	}

	[Token(Token = "0x6006109")]
	[Address(RVA = "0x315DBAC", Offset = "0x315DBAC", VA = "0x315DBAC")]
	public void RemoveBind(UIVariableBind bind)
	{
	}

	[Token(Token = "0x600610A")]
	[Address(RVA = "0x315D0F4", Offset = "0x315D0F4", VA = "0x315D0F4")]
	internal void InvokeValueChange()
	{
	}

	[Token(Token = "0x600610B")]
	[Address(RVA = "0x315CF98", Offset = "0x315CF98", VA = "0x315CF98")]
	internal void InvokeValueInit()
	{
	}

	[Token(Token = "0x600610C")]
	[Address(RVA = "0x315DC2C", Offset = "0x315DC2C", VA = "0x315DC2C")]
	internal void ClearBinderList()
	{
	}

	[Token(Token = "0x600610D")]
	[Address(RVA = "0x315B858", Offset = "0x315B858", VA = "0x315B858")]
	internal void ResetValue()
	{
	}

	[Token(Token = "0x600610E")]
	[Address(RVA = "0x315DD2C", Offset = "0x315DD2C", VA = "0x315DD2C")]
	private static bool _003CClearBinderList_003Em__0(UIVariableBind P_0)
	{
		return default(bool);
	}
}
