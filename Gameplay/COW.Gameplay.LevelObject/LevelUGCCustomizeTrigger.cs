using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay.LevelObject;

[Token(Token = "0x20006D7")]
public class LevelUGCCustomizeTrigger : BaseAutoGenIDLevelObject, _Attribute
{
	[Token(Token = "0x4004B01")]
	[FieldOffset(Offset = "0x74")]
	private CustomizeTriggerEntity m_EntityData;

	[Token(Token = "0x4004B02")]
	[FieldOffset(Offset = "0x78")]
	public GameObject EditOnlyModel;

	[Token(Token = "0x6002BB0")]
	[Address(RVA = "0x24A26EC", Offset = "0x24A26EC", VA = "0x24A26EC")]
	public LevelUGCCustomizeTrigger()
	{
	}

	[Token(Token = "0x6002BB1")]
	[Address(RVA = "0x24A26F4", Offset = "0x24A26F4", VA = "0x24A26F4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002BB2")]
	[Address(RVA = "0x24A2750", Offset = "0x24A2750", VA = "0x24A2750", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002BB3")]
	[Address(RVA = "0x24A296C", Offset = "0x24A296C", VA = "0x24A296C")]
	public void SetModelVisible(bool isEditMode)
	{
	}

	[Token(Token = "0x6002BB4")]
	[Address(RVA = "0x24A27E0", Offset = "0x24A27E0", VA = "0x24A27E0")]
	public void SetEntityID()
	{
	}

	[Token(Token = "0x6002BB5")]
	[Address(RVA = "0x24A2A28", Offset = "0x24A2A28", VA = "0x24A2A28", Slot = "31")]
	public override void SyncAction(object[] param)
	{
	}

	[Token(Token = "0x6002BB6")]
	[Address(RVA = "0x24A2B50", Offset = "0x24A2B50", VA = "0x24A2B50")]
	private void DoUgcLevelObjectDel()
	{
	}

	[Token(Token = "0x6002BB7")]
	[Address(RVA = "0x24A2C24", Offset = "0x24A2C24", VA = "0x24A2C24", Slot = "41")]
	public void ProcessTriggerColliderInCrossHairState()
	{
	}

	[Token(Token = "0x6002BB8")]
	[Address(RVA = "0x24A2D14", Offset = "0x24A2D14", VA = "0x24A2D14")]
	private void OnEnableChangeEvent(bool oldValue, bool newValue)
	{
	}
}
