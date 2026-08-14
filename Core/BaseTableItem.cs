using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002D1E")]
public class BaseTableItem : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4011387")]
	[FieldOffset(Offset = "0xC")]
	private UIWidget m_Widget;

	[Token(Token = "0x4011388")]
	[FieldOffset(Offset = "0x10")]
	protected bool m_HasInit;

	[Token(Token = "0x4011389")]
	[FieldOffset(Offset = "0x11")]
	public bool m_SkipPadding;

	[Token(Token = "0x6012DD0")]
	[Address(RVA = "0x2ECFCC4", Offset = "0x2ECFCC4", VA = "0x2ECFCC4")]
	public BaseTableItem()
	{
	}

	[Token(Token = "0x6012DD1")]
	[Address(RVA = "0x2ECFCCC", Offset = "0x2ECFCCC", VA = "0x2ECFCCC", Slot = "8")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6012DD2")]
	[Address(RVA = "0x2ECFD90", Offset = "0x2ECFD90", VA = "0x2ECFD90", Slot = "9")]
	public virtual void UnInit()
	{
	}

	[Token(Token = "0x6012DD3")]
	[Address(RVA = "0x2ECFD9C", Offset = "0x2ECFD9C", VA = "0x2ECFD9C", Slot = "10")]
	public virtual Vector2 GetSize()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012DD4")]
	[Address(RVA = "0x2ECFEF8", Offset = "0x2ECFEF8", VA = "0x2ECFEF8", Slot = "11")]
	protected virtual void EditorExecute()
	{
	}

	[Token(Token = "0x6012DD5")]
	[Address(RVA = "0x2ECFFEC", Offset = "0x2ECFFEC", VA = "0x2ECFFEC", Slot = "12")]
	public virtual bool SkipPadding()
	{
		return default(bool);
	}
}
