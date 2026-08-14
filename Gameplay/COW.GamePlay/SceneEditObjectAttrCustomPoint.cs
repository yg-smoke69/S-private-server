using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000AD9")]
internal class SceneEditObjectAttrCustomPoint : SceneEditObjectAttrBase
{
	[Token(Token = "0x4005E87")]
	[FieldOffset(Offset = "0x28")]
	public UGCLevelCustomPath Path;

	[Token(Token = "0x4005E88")]
	[FieldOffset(Offset = "0x2C")]
	public int PointIndex;

	[Token(Token = "0x4005E89")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 LCPODCHKIBD;

	[Token(Token = "0x6005368")]
	[Address(RVA = "0x1D6517C", Offset = "0x1D6517C", VA = "0x1D6517C")]
	public SceneEditObjectAttrCustomPoint()
	{
	}

	[Token(Token = "0x6005369")]
	[Address(RVA = "0x1D6518C", Offset = "0x1D6518C", VA = "0x1D6518C", Slot = "7")]
	public override void CopyExtraDataFromObjectToAttribute(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x600536A")]
	[Address(RVA = "0x1D6533C", Offset = "0x1D6533C", VA = "0x1D6533C", Slot = "9")]
	public override void CopyExtraDataFromAttributeToObject(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x600536B")]
	[Address(RVA = "0x1D656F0", Offset = "0x1D656F0", VA = "0x1D656F0")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x600536C")]
	[Address(RVA = "0x1D65A1C", Offset = "0x1D65A1C", VA = "0x1D65A1C", Slot = "12")]
	public override void RemoveIfAllowed(Action HLLGOKLLGEH)
	{
	}

	[Token(Token = "0x600536D")]
	[Address(RVA = "0x1D65EA4", Offset = "0x1D65EA4", VA = "0x1D65EA4", Slot = "4")]
	public override void OnCustomizedNameSetted()
	{
	}

	[Token(Token = "0x600536E")]
	[Address(RVA = "0x1D66174", Offset = "0x1D66174", VA = "0x1D66174", Slot = "8")]
	public override void Duplicate(bool ALBMECLFAJG, SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x600536F")]
	[Address(RVA = "0x1D66330", Offset = "0x1D66330", VA = "0x1D66330", Slot = "11")]
	public override void ClearData()
	{
	}

	[Token(Token = "0x6005370")]
	[Address(RVA = "0x1D663A4", Offset = "0x1D663A4", VA = "0x1D663A4")]
	public void _003C_003EiFixBaseProxy_CopyExtraDataFromObjectToAttribute(SceneEditObjectBase P0)
	{
	}

	[Token(Token = "0x6005371")]
	[Address(RVA = "0x1D663AC", Offset = "0x1D663AC", VA = "0x1D663AC")]
	public void _003C_003EiFixBaseProxy_CopyExtraDataFromAttributeToObject(SceneEditObjectBase P0)
	{
	}

	[Token(Token = "0x6005372")]
	[Address(RVA = "0x1D663B4", Offset = "0x1D663B4", VA = "0x1D663B4")]
	public void _003C_003EiFixBaseProxy_RemoveIfAllowed(Action P0)
	{
	}

	[Token(Token = "0x6005373")]
	[Address(RVA = "0x1D663BC", Offset = "0x1D663BC", VA = "0x1D663BC")]
	public void _003C_003EiFixBaseProxy_OnCustomizedNameSetted()
	{
	}

	[Token(Token = "0x6005374")]
	[Address(RVA = "0x1D663C4", Offset = "0x1D663C4", VA = "0x1D663C4")]
	public void _003C_003EiFixBaseProxy_Duplicate(bool P0, SceneEditObjectBase P1)
	{
	}

	[Token(Token = "0x6005375")]
	[Address(RVA = "0x1D663CC", Offset = "0x1D663CC", VA = "0x1D663CC")]
	public void _003C_003EiFixBaseProxy_ClearData()
	{
	}
}
