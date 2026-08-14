using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay.LevelObject;

[Token(Token = "0x20006DA")]
public class LevelUGCSupplyBoxTrigger : LevelUGCCustomizeTrigger
{
	[Token(Token = "0x20006DB")]
	public enum EUGCCSupplyBoxModelType
	{
		[Token(Token = "0x4004B0C")]
		None,
		[Token(Token = "0x4004B0D")]
		Normal,
		[Token(Token = "0x4004B0E")]
		Zombie
	}

	[Token(Token = "0x4004B09")]
	[FieldOffset(Offset = "0x7C")]
	private SupplyBoxTriggerEntity m_EntityData;

	[Token(Token = "0x4004B0A")]
	[FieldOffset(Offset = "0x80")]
	private GameObject m_Model;

	[Token(Token = "0x6002BC2")]
	[Address(RVA = "0x24A2E50", Offset = "0x24A2E50", VA = "0x24A2E50")]
	public LevelUGCSupplyBoxTrigger()
	{
	}

	[Token(Token = "0x6002BC3")]
	[Address(RVA = "0x24A2E58", Offset = "0x24A2E58", VA = "0x24A2E58", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002BC4")]
	[Address(RVA = "0x24A2EB4", Offset = "0x24A2EB4", VA = "0x24A2EB4", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002BC5")]
	[Address(RVA = "0x24A2F44", Offset = "0x24A2F44", VA = "0x24A2F44")]
	public new void SetEntityID()
	{
	}

	[Token(Token = "0x6002BC6")]
	[Address(RVA = "0x24A31CC", Offset = "0x24A31CC", VA = "0x24A31CC")]
	private void OnModelChangeEvent(int oldValue, int newValue)
	{
	}

	[Token(Token = "0x6002BC7")]
	[Address(RVA = "0x24A3868", Offset = "0x24A3868", VA = "0x24A3868")]
	private void OnEnableChangeEvent(bool oldValue, bool newValue)
	{
	}

	[Token(Token = "0x6002BC8")]
	[Address(RVA = "0x24A378C", Offset = "0x24A378C", VA = "0x24A378C")]
	private ResourceID GetResourceIDByType(EUGCCSupplyBoxModelType type)
	{
		return default(ResourceID);
	}
}
