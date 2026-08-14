using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000AD5")]
public class SceneEditObjectAttrBase : MonoBehaviour
{
	[Token(Token = "0x4005E6F")]
	[FieldOffset(Offset = "0xC")]
	private ModeVariables IOFMIGNGEKI;

	[Token(Token = "0x4005E70")]
	[FieldOffset(Offset = "0x10")]
	public string LogicEntityID;

	[Token(Token = "0x4005E71")]
	[FieldOffset(Offset = "0x14")]
	private string PCCFEIGOMLN;

	[Token(Token = "0x4005E72")]
	[FieldOffset(Offset = "0x18")]
	public bool IsDuplicate;

	[Token(Token = "0x4005E73")]
	[FieldOffset(Offset = "0x1C")]
	public string DuplicateBaseName;

	[Token(Token = "0x4005E74")]
	[FieldOffset(Offset = "0x20")]
	public bool IsCustomizedNameChanged;

	[Token(Token = "0x4005E75")]
	[FieldOffset(Offset = "0x24")]
	private uint m_resetEveryRound;

	[Token(Token = "0x1700069C")]
	public ModeVariables BGEAGMOJEKD
	{
		[Token(Token = "0x600534A")]
		[Address(RVA = "0x29CE1C4", Offset = "0x29CE1C4", VA = "0x29CE1C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600534B")]
		[Address(RVA = "0x29CE21C", Offset = "0x29CE21C", VA = "0x29CE21C")]
		set
		{
		}
	}

	[Token(Token = "0x1700069D")]
	public string GIKMAINHGGK
	{
		[Token(Token = "0x600534C")]
		[Address(RVA = "0x29C663C", Offset = "0x29C663C", VA = "0x29C663C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600534D")]
		[Address(RVA = "0x29C7138", Offset = "0x29C7138", VA = "0x29C7138")]
		set
		{
		}
	}

	[Token(Token = "0x1700069E")]
	public uint LIHADPNHGMC
	{
		[Token(Token = "0x6005357")]
		[Address(RVA = "0x29CE9F0", Offset = "0x29CE9F0", VA = "0x29CE9F0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6005358")]
		[Address(RVA = "0x29CE474", Offset = "0x29CE474", VA = "0x29CE474")]
		set
		{
		}
	}

	[Token(Token = "0x6005349")]
	[Address(RVA = "0x29CE0EC", Offset = "0x29CE0EC", VA = "0x29CE0EC")]
	public SceneEditObjectAttrBase()
	{
	}

	[Token(Token = "0x600534E")]
	[Address(RVA = "0x29CE294", Offset = "0x29CE294", VA = "0x29CE294", Slot = "4")]
	public virtual void OnCustomizedNameSetted()
	{
	}

	[Token(Token = "0x600534F")]
	[Address(RVA = "0x29CE2E8", Offset = "0x29CE2E8", VA = "0x29CE2E8", Slot = "5")]
	public virtual void AfterAttributeChangeInCrosshairState()
	{
	}

	[Token(Token = "0x6005350")]
	[Address(RVA = "0x29CE33C", Offset = "0x29CE33C", VA = "0x29CE33C", Slot = "6")]
	public virtual void AfterAttributeApplyToSceneEditObject()
	{
	}

	[Token(Token = "0x6005351")]
	[Address(RVA = "0x29CE390", Offset = "0x29CE390", VA = "0x29CE390", Slot = "7")]
	public virtual void CopyExtraDataFromObjectToAttribute(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6005352")]
	[Address(RVA = "0x29CE4D4", Offset = "0x29CE4D4", VA = "0x29CE4D4", Slot = "8")]
	public virtual void Duplicate(bool ALBMECLFAJG, SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6005353")]
	[Address(RVA = "0x29CE74C", Offset = "0x29CE74C", VA = "0x29CE74C", Slot = "9")]
	public virtual void CopyExtraDataFromAttributeToObject(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6005354")]
	[Address(RVA = "0x29CEA48", Offset = "0x29CEA48", VA = "0x29CEA48", Slot = "10")]
	public virtual void OnSetVariables()
	{
	}

	[Token(Token = "0x6005355")]
	[Address(RVA = "0x29CEA9C", Offset = "0x29CEA9C", VA = "0x29CEA9C", Slot = "11")]
	public virtual void ClearData()
	{
	}

	[Token(Token = "0x6005356")]
	[Address(RVA = "0x29CEB88", Offset = "0x29CEB88", VA = "0x29CEB88", Slot = "12")]
	public virtual void RemoveIfAllowed(Action HLLGOKLLGEH)
	{
	}
}
