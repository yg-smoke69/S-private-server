using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200414B")]
public class UIInnerView
{
	[Token(Token = "0x401B65D")]
	[FieldOffset(Offset = "0x8")]
	private GameObject ui;

	[Token(Token = "0x401B65E")]
	[FieldOffset(Offset = "0xC")]
	private UIItemVariable[] itemVars;

	[Token(Token = "0x401B65F")]
	[FieldOffset(Offset = "0x10")]
	private bool inited;

	[Token(Token = "0x601AAE2")]
	[Address(RVA = "0x2CA3E58", Offset = "0x2CA3E58", VA = "0x2CA3E58")]
	public UIInnerView()
	{
	}

	[Token(Token = "0x601AAE3")]
	[Address(RVA = "0x2CA3E60", Offset = "0x2CA3E60", VA = "0x2CA3E60")]
	public bool Inited()
	{
		return default(bool);
	}

	[Token(Token = "0x601AAE4")]
	[Address(RVA = "0x2CA3E68", Offset = "0x2CA3E68", VA = "0x2CA3E68", Slot = "4")]
	public virtual void BindVars(GameObject ui)
	{
	}

	[Token(Token = "0x601AAE5")]
	public T Clone<T>() where T : UIInnerView, new()
	{
		return null;
	}

	[Token(Token = "0x601AAE6")]
	protected void Bind<T>(out T feild, string name) where T : Object
	{
	}
}
