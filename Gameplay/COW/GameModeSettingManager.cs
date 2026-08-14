using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200028B")]
internal class GameModeSettingManager : SingletonModule<GameModeSettingManager>
{
	[Token(Token = "0x40017F4")]
	[FieldOffset(Offset = "0xC")]
	private GameModeSetting m_DefaultGameSetting;

	[Token(Token = "0x40017F5")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<ulong, GameModeSetting> m_GameModeSettings;

	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x1DD6BA8", Offset = "0x1DD6BA8", VA = "0x1DD6BA8")]
	public GameModeSettingManager()
	{
	}

	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x1DD6C6C", Offset = "0x1DD6C6C", VA = "0x1DD6C6C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x1DD6F98", Offset = "0x1DD6F98", VA = "0x1DD6F98", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x1DD6FEC", Offset = "0x1DD6FEC", VA = "0x1DD6FEC")]
	public GameModeSetting GetModeSetting(uint map_id, uint mode_id, bool isWaitingRoom)
	{
		return null;
	}

	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x1DD739C", Offset = "0x1DD739C", VA = "0x1DD739C")]
	private ulong GetModeSettingKey(uint map_id, uint mode_id, bool isWaitingRoom)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x1DD6D80", Offset = "0x1DD6D80", VA = "0x1DD6D80")]
	private GameModeSetting LoadModeSetting(ResourceID resID, [Optional] GameModeSetting defaultSetting)
	{
		return null;
	}
}
