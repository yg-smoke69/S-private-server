using System.Collections.Generic;
using COW.GamePlay;
using FFVoice;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E23")]
public class SparkEventManager
{
	[Token(Token = "0x400BE70")]
	[FieldOffset(Offset = "0x0")]
	private static SparkEventManager _instance;

	[Token(Token = "0x400BE71")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, SparkEventConfigData> m_EventConfig;

	[Token(Token = "0x400BE72")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, int> m_EventCountCache;

	[Token(Token = "0x400BE73")]
	[FieldOffset(Offset = "0x10")]
	private bool _003CIsConnectedMTV_003Ek__BackingField;

	[Token(Token = "0x400BE74")]
	[FieldOffset(Offset = "0x11")]
	private bool _003CIsMicInMTV_003Ek__BackingField;

	[Token(Token = "0x17000F19")]
	public static SparkEventManager instance
	{
		[Token(Token = "0x6008FE9")]
		[Address(RVA = "0x20F620C", Offset = "0x20F620C", VA = "0x20F620C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F1A")]
	public static bool IsEnabled
	{
		[Token(Token = "0x6008FEA")]
		[Address(RVA = "0x20F6378", Offset = "0x20F6378", VA = "0x20F6378")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F1B")]
	public bool IsConnectedMTV
	{
		[Token(Token = "0x6008FEB")]
		[Address(RVA = "0x20F6514", Offset = "0x20F6514", VA = "0x20F6514")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008FEC")]
		[Address(RVA = "0x20F651C", Offset = "0x20F651C", VA = "0x20F651C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000F1C")]
	public bool IsMicInMTV
	{
		[Token(Token = "0x6008FED")]
		[Address(RVA = "0x20F6524", Offset = "0x20F6524", VA = "0x20F6524")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008FEE")]
		[Address(RVA = "0x20F652C", Offset = "0x20F652C", VA = "0x20F652C")]
		private set
		{
		}
	}

	[Token(Token = "0x6008FE8")]
	[Address(RVA = "0x20F614C", Offset = "0x20F614C", VA = "0x20F614C")]
	public SparkEventManager()
	{
	}

	[Token(Token = "0x6008FEF")]
	[Address(RVA = "0x20F6534", Offset = "0x20F6534", VA = "0x20F6534")]
	public void Init()
	{
	}

	[Token(Token = "0x6008FF0")]
	[Address(RVA = "0x20F6C60", Offset = "0x20F6C60", VA = "0x20F6C60")]
	public void OnLogin(ulong account_id)
	{
	}

	[Token(Token = "0x6008FF1")]
	[Address(RVA = "0x20F6B10", Offset = "0x20F6B10", VA = "0x20F6B10")]
	private void StartVoiceDataSender()
	{
	}

	[Token(Token = "0x6008FF2")]
	[Address(RVA = "0x20F716C", Offset = "0x20F716C", VA = "0x20F716C")]
	private void StopVoiceDataSender()
	{
	}

	[Token(Token = "0x6008FF3")]
	[Address(RVA = "0x20F72BC", Offset = "0x20F72BC", VA = "0x20F72BC")]
	public void OnSceneLoaded()
	{
	}

	[Token(Token = "0x6008FF4")]
	[Address(RVA = "0x20F7384", Offset = "0x20F7384", VA = "0x20F7384")]
	private void OnConnectedChanged(bool is_connected)
	{
	}

	[Token(Token = "0x6008FF5")]
	[Address(RVA = "0x20F77A8", Offset = "0x20F77A8", VA = "0x20F77A8")]
	private void OnMicFocusChanged(bool is_focused)
	{
	}

	[Token(Token = "0x6008FF6")]
	[Address(RVA = "0x20F7808", Offset = "0x20F7808", VA = "0x20F7808")]
	public void RequestReleaseMic()
	{
	}

	[Token(Token = "0x6008FF7")]
	[Address(RVA = "0x20F78DC", Offset = "0x20F78DC", VA = "0x20F78DC")]
	public void RequestResumeMic()
	{
	}

	[Token(Token = "0x6008FF8")]
	[Address(RVA = "0x20F79B0", Offset = "0x20F79B0", VA = "0x20F79B0")]
	public void OnFreeFireVoiceCaptureStart()
	{
	}

	[Token(Token = "0x6008FF9")]
	[Address(RVA = "0x20F7A78", Offset = "0x20F7A78", VA = "0x20F7A78")]
	public void OnFreeFireVoiceCaptureStop()
	{
	}

	[Token(Token = "0x6008FFA")]
	[Address(RVA = "0x20F7B40", Offset = "0x20F7B40", VA = "0x20F7B40")]
	public void OnFFVoiceCaptured(FFVoiceAPI.FFVoicePcmCallbackData data)
	{
	}

	[Token(Token = "0x6008FFB")]
	[Address(RVA = "0x20F6DA8", Offset = "0x20F6DA8", VA = "0x20F6DA8")]
	public void ClearEventCountCache()
	{
	}

	[Token(Token = "0x6008FFC")]
	[Address(RVA = "0x20F7C5C", Offset = "0x20F7C5C", VA = "0x20F7C5C")]
	private void PushEvent(SparkEventData_Base data)
	{
	}

	[Token(Token = "0x6008FFD")]
	[Address(RVA = "0x20F6E68", Offset = "0x20F6E68", VA = "0x20F6E68")]
	public void RecordEnterLobby()
	{
	}

	[Token(Token = "0x6008FFE")]
	[Address(RVA = "0x20F7FA4", Offset = "0x20F7FA4", VA = "0x20F7FA4")]
	public void RecordGameStart()
	{
	}

	[Token(Token = "0x6008FFF")]
	[Address(RVA = "0x20F81A8", Offset = "0x20F81A8", VA = "0x20F81A8")]
	public void RecordGameEnd(bool win)
	{
	}

	[Token(Token = "0x6009000")]
	[Address(RVA = "0x20F8320", Offset = "0x20F8320", VA = "0x20F8320")]
	public void RecordPlaneJump()
	{
	}

	[Token(Token = "0x6009001")]
	[Address(RVA = "0x20F8488", Offset = "0x20F8488", VA = "0x20F8488")]
	public void RecordLanding()
	{
	}

	[Token(Token = "0x6009002")]
	[Address(RVA = "0x20F85F0", Offset = "0x20F85F0", VA = "0x20F85F0")]
	public void RecordDamageEnemy(ulong _account_id, int _damge_dealt, int _weapon_id, bool _hit_head)
	{
	}

	[Token(Token = "0x6009003")]
	[Address(RVA = "0x20F880C", Offset = "0x20F880C", VA = "0x20F880C")]
	public void RecordDamgeTaken(IHAAMHPPLMG _damager, int _damage_taken, int _remaining_hp, int _weapon_id)
	{
	}

	[Token(Token = "0x6009004")]
	[Address(RVA = "0x20F8B60", Offset = "0x20F8B60", VA = "0x20F8B60")]
	public void RecordKill(IHAAMHPPLMG _player_id, int _weapon_id, int _kill_count)
	{
	}

	[Token(Token = "0x6009005")]
	[Address(RVA = "0x20F8E88", Offset = "0x20F8E88", VA = "0x20F8E88")]
	public void RecordKillTeamLastOne(IHAAMHPPLMG _player_id, int _weapon_id)
	{
	}

	[Token(Token = "0x6009006")]
	[Address(RVA = "0x20F9170", Offset = "0x20F9170", VA = "0x20F9170")]
	public void RecordAttainmentKill(IHAAMHPPLMG _player_id)
	{
	}

	[Token(Token = "0x6009007")]
	[Address(RVA = "0x20F9420", Offset = "0x20F9420", VA = "0x20F9420")]
	public void RecordLocalPlayerDeath(IHAAMHPPLMG killer_id, int _weapon_id)
	{
	}

	[Token(Token = "0x6009008")]
	[Address(RVA = "0x20F95D8", Offset = "0x20F95D8", VA = "0x20F95D8")]
	public void RecordKnockDown(IHAAMHPPLMG killer_id, IHAAMHPPLMG knocked_down_id, int _weapon_id)
	{
	}

	[Token(Token = "0x6009009")]
	[Address(RVA = "0x20F9B70", Offset = "0x20F9B70", VA = "0x20F9B70")]
	public void RecordRevive(IHAAMHPPLMG revive_id, IHAAMHPPLMG revived_id)
	{
	}

	[Token(Token = "0x600900A")]
	[Address(RVA = "0x20FA0F4", Offset = "0x20FA0F4", VA = "0x20FA0F4")]
	public void RecordReviveTeammates(IHAAMHPPLMG reviver_id, IHAAMHPPLMG revived_id)
	{
	}

	[Token(Token = "0x600900B")]
	[Address(RVA = "0x20FA51C", Offset = "0x20FA51C", VA = "0x20FA51C")]
	public void RecordPickUpItem(uint _item_id, uint _skin_id)
	{
	}

	[Token(Token = "0x600900C")]
	[Address(RVA = "0x20FA6D0", Offset = "0x20FA6D0", VA = "0x20FA6D0")]
	public void RecordLootContainer(byte type, List<MNGBAPBBJDC> pick_up_list)
	{
	}

	[Token(Token = "0x600900D")]
	[Address(RVA = "0x20FA990", Offset = "0x20FA990", VA = "0x20FA990")]
	private void RecordLootAirDrop(uint[] _item_ids)
	{
	}

	[Token(Token = "0x600900E")]
	[Address(RVA = "0x20FAB14", Offset = "0x20FAB14", VA = "0x20FAB14")]
	private void RecordLootPlayer(uint[] _item_ids)
	{
	}

	[Token(Token = "0x600900F")]
	[Address(RVA = "0x20FAC98", Offset = "0x20FAC98", VA = "0x20FAC98")]
	public void RecordUAVExpose(object list_data, IHAAMHPPLMG ownerID)
	{
	}

	[Token(Token = "0x6009010")]
	[Address(RVA = "0x20FB2A0", Offset = "0x20FB2A0", VA = "0x20FB2A0")]
	public void RecordUseItem(uint _item_id)
	{
	}

	[Token(Token = "0x6009011")]
	[Address(RVA = "0x20FB424", Offset = "0x20FB424", VA = "0x20FB424")]
	public void RecordEnterVehicle(int _vehicle_id, int _vehicle_hp)
	{
	}

	[Token(Token = "0x6009012")]
	[Address(RVA = "0x20FB5D8", Offset = "0x20FB5D8", VA = "0x20FB5D8")]
	public void RecordExitVehicle(int _vehicle_id, int _vehicle_hp)
	{
	}

	[Token(Token = "0x6009013")]
	[Address(RVA = "0x20FB78C", Offset = "0x20FB78C", VA = "0x20FB78C")]
	public void RecordBattlePassLevel(uint _pass_lvl, bool _is_elite)
	{
	}

	[Token(Token = "0x6009014")]
	[Address(RVA = "0x20FB940", Offset = "0x20FB940", VA = "0x20FB940")]
	public void RecordSurviorCount(int _survior_count)
	{
	}
}
