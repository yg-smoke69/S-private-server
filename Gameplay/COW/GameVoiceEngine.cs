using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000D36")]
public class GameVoiceEngine : MonoBehaviour
{
	[Token(Token = "0x2000D37")]
	private enum EChannelPauseReason
	{
		[Token(Token = "0x4006AE9")]
		eNone,
		[Token(Token = "0x4006AEA")]
		eAppPause,
		[Token(Token = "0x4006AEB")]
		eMute
	}

	[Token(Token = "0x2000D38")]
	private delegate void OnLeavedRoom();

	[Token(Token = "0x2000D39")]
	private delegate void OnJoinedRoom();

	[Token(Token = "0x2000D3A")]
	private class Json_MemberChangeInfo
	{
		[Token(Token = "0x4006AEC")]
		[FieldOffset(Offset = "0x8")]
		public string channelid;

		[Token(Token = "0x4006AED")]
		[FieldOffset(Offset = "0xC")]
		public Json_MemberInfo[] memchange;

		[Token(Token = "0x4006AEE")]
		[FieldOffset(Offset = "0x10")]
		public int type;

		[Token(Token = "0x600656A")]
		[Address(RVA = "0x24A17EC", Offset = "0x24A17EC", VA = "0x24A17EC")]
		public Json_MemberChangeInfo()
		{
		}
	}

	[Token(Token = "0x2000D3B")]
	private class Json_MemberInfo
	{
		[Token(Token = "0x4006AEF")]
		[FieldOffset(Offset = "0x8")]
		public bool isJoin;

		[Token(Token = "0x4006AF0")]
		[FieldOffset(Offset = "0xC")]
		public string userid;

		[Token(Token = "0x600656B")]
		[Address(RVA = "0x24A188C", Offset = "0x24A188C", VA = "0x24A188C")]
		public Json_MemberInfo()
		{
		}
	}

	[Token(Token = "0x2000D3C")]
	public class Json_ReportAudio
	{
		[Token(Token = "0x4006AF1")]
		[FieldOffset(Offset = "0x8")]
		public string report_id;

		[Token(Token = "0x4006AF2")]
		[FieldOffset(Offset = "0xC")]
		public string user_id;

		[Token(Token = "0x4006AF3")]
		[FieldOffset(Offset = "0x10")]
		public string report_user_id;

		[Token(Token = "0x4006AF4")]
		[FieldOffset(Offset = "0x14")]
		public string room_id;

		[Token(Token = "0x4006AF5")]
		[FieldOffset(Offset = "0x18")]
		public uint mask_time;

		[Token(Token = "0x4006AF6")]
		[FieldOffset(Offset = "0x1C")]
		public int mask_timestamp;

		[Token(Token = "0x4006AF7")]
		[FieldOffset(Offset = "0x20")]
		public int report_timestamp;

		[Token(Token = "0x4006AF8")]
		[FieldOffset(Offset = "0x24")]
		public string business_param;

		[Token(Token = "0x4006AF9")]
		[FieldOffset(Offset = "0x28")]
		public string custom_data;

		[Token(Token = "0x600656C")]
		[Address(RVA = "0x24A1934", Offset = "0x24A1934", VA = "0x24A1934")]
		public Json_ReportAudio()
		{
		}
	}

	[Token(Token = "0x2000D3D")]
	public class Json_Business_Param
	{
		[Token(Token = "0x4006AFA")]
		[FieldOffset(Offset = "0x8")]
		public int behavior_ruleid;

		[Token(Token = "0x600656D")]
		[Address(RVA = "0x24A1738", Offset = "0x24A1738", VA = "0x24A1738")]
		public Json_Business_Param()
		{
		}
	}

	[Token(Token = "0x2000D3E")]
	public class Json_Custom_Data
	{
		[Token(Token = "0x4006AFB")]
		[FieldOffset(Offset = "0x8")]
		public string match_id;

		[Token(Token = "0x4006AFC")]
		[FieldOffset(Offset = "0xC")]
		public string match_create_time;

		[Token(Token = "0x600656E")]
		[Address(RVA = "0x24A1740", Offset = "0x24A1740", VA = "0x24A1740")]
		public Json_Custom_Data()
		{
		}
	}

	[Token(Token = "0x2000D3F")]
	public class Json_Mute_Data
	{
		[Token(Token = "0x4006AFD")]
		[FieldOffset(Offset = "0x8")]
		public uint mask_timestamp;

		[Token(Token = "0x600656F")]
		[Address(RVA = "0x24A192C", Offset = "0x24A192C", VA = "0x24A192C")]
		public Json_Mute_Data()
		{
		}
	}

	[Token(Token = "0x2000D40")]
	private sealed class _003CToggleMicrophoneMute_003Ec__AnonStorey0
	{
		[Token(Token = "0x4006AFE")]
		[FieldOffset(Offset = "0x8")]
		internal bool backEndMute;

		[Token(Token = "0x4006AFF")]
		[FieldOffset(Offset = "0xC")]
		internal GameVoiceEngine _0024this;

		[Token(Token = "0x6006570")]
		[Address(RVA = "0x2498810", Offset = "0x2498810", VA = "0x2498810")]
		public _003CToggleMicrophoneMute_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6006571")]
		[Address(RVA = "0x24A1180", Offset = "0x24A1180", VA = "0x24A1180")]
		internal void _003C_003Em__0(Dictionary<int, bool> results)
		{
		}
	}

	[Token(Token = "0x2000D41")]
	private sealed class _003COnMemberChange_003Ec__AnonStorey1
	{
		[Token(Token = "0x4006B00")]
		[FieldOffset(Offset = "0x8")]
		internal string strParam;

		[Token(Token = "0x6006572")]
		[Address(RVA = "0x249CB0C", Offset = "0x249CB0C", VA = "0x249CB0C")]
		public _003COnMemberChange_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6006573")]
		[Address(RVA = "0x24A1020", Offset = "0x24A1020", VA = "0x24A1020")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2000D42")]
	private sealed class _003COnEvent_003Ec__AnonStorey2
	{
		[Token(Token = "0x4006B01")]
		[FieldOffset(Offset = "0x8")]
		internal string channelID;

		[Token(Token = "0x4006B02")]
		[FieldOffset(Offset = "0xC")]
		internal string param;

		[Token(Token = "0x4006B03")]
		[FieldOffset(Offset = "0x10")]
		internal int errorCode;

		[Token(Token = "0x4006B04")]
		[FieldOffset(Offset = "0x14")]
		internal GameVoiceEngine _0024this;

		[Token(Token = "0x6006574")]
		[Address(RVA = "0x249CB14", Offset = "0x249CB14", VA = "0x249CB14")]
		public _003COnEvent_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6006575")]
		[Address(RVA = "0x249FD04", Offset = "0x249FD04", VA = "0x249FD04")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6006576")]
		[Address(RVA = "0x249FDBC", Offset = "0x249FDBC", VA = "0x249FDBC")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6006577")]
		[Address(RVA = "0x24A0524", Offset = "0x24A0524", VA = "0x24A0524")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x6006578")]
		[Address(RVA = "0x24A05E8", Offset = "0x24A05E8", VA = "0x24A05E8")]
		internal void _003C_003Em__3()
		{
		}

		[Token(Token = "0x6006579")]
		[Address(RVA = "0x24A068C", Offset = "0x24A068C", VA = "0x24A068C")]
		internal void _003C_003Em__4()
		{
		}

		[Token(Token = "0x600657A")]
		[Address(RVA = "0x24A0730", Offset = "0x24A0730", VA = "0x24A0730")]
		internal void _003C_003Em__5()
		{
		}

		[Token(Token = "0x600657B")]
		[Address(RVA = "0x24A07D4", Offset = "0x24A07D4", VA = "0x24A07D4")]
		internal void _003C_003Em__6()
		{
		}

		[Token(Token = "0x600657C")]
		[Address(RVA = "0x24A0878", Offset = "0x24A0878", VA = "0x24A0878")]
		internal void _003C_003Em__7()
		{
		}

		[Token(Token = "0x600657D")]
		[Address(RVA = "0x24A09E0", Offset = "0x24A09E0", VA = "0x24A09E0")]
		internal void _003C_003Em__8()
		{
		}

		[Token(Token = "0x600657E")]
		[Address(RVA = "0x24A0D98", Offset = "0x24A0D98", VA = "0x24A0D98")]
		internal void _003C_003Em__9()
		{
		}

		[Token(Token = "0x600657F")]
		[Address(RVA = "0x24A0E3C", Offset = "0x24A0E3C", VA = "0x24A0E3C")]
		internal void _003C_003Em__A()
		{
		}

		[Token(Token = "0x6006580")]
		[Address(RVA = "0x24A0EE0", Offset = "0x24A0EE0", VA = "0x24A0EE0")]
		internal void _003C_003Em__B()
		{
		}

		[Token(Token = "0x6006581")]
		[Address(RVA = "0x24A0F80", Offset = "0x24A0F80", VA = "0x24A0F80")]
		internal void _003C_003Em__C()
		{
		}
	}

	[Token(Token = "0x4006AC9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] _MicPermissions;

	[Token(Token = "0x4006ACA")]
	[FieldOffset(Offset = "0xC")]
	private ChannelState m_CurrentState;

	[Token(Token = "0x4006ACB")]
	[FieldOffset(Offset = "0x10")]
	private bool m_EngineInited;

	[Token(Token = "0x4006ACC")]
	[FieldOffset(Offset = "0x14")]
	private string m_UserID;

	[Token(Token = "0x4006ACD")]
	[FieldOffset(Offset = "0x18")]
	private OnLeavedRoom onLeavedRoom;

	[Token(Token = "0x4006ACE")]
	[FieldOffset(Offset = "0x1C")]
	private OnJoinedRoom onJoinedRoom;

	[Token(Token = "0x4006ACF")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int MAX_JOIN_RETRY_COUNT;

	[Token(Token = "0x4006AD0")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int MAX_INIT_RETRY_COUNT;

	[Token(Token = "0x4006AD1")]
	[FieldOffset(Offset = "0xC")]
	private static readonly float RETRY_DEALY_SECOUND;

	[Token(Token = "0x4006AD2")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsMicroPhoneMute;

	[Token(Token = "0x4006AD3")]
	[FieldOffset(Offset = "0x21")]
	private bool m_IsSpeakerMute;

	[Token(Token = "0x4006AD4")]
	[FieldOffset(Offset = "0x24")]
	private uint m_GameVoiceVolume;

	[Token(Token = "0x4006AD5")]
	[FieldOffset(Offset = "0x10")]
	private static GameVoiceEngine _instance;

	[Token(Token = "0x4006AD6")]
	[FieldOffset(Offset = "0x28")]
	private List<Action> _actions;

	[Token(Token = "0x4006AD7")]
	[FieldOffset(Offset = "0x2C")]
	private List<Action> _currentActions;

	[Token(Token = "0x4006AD8")]
	[FieldOffset(Offset = "0x30")]
	private int m_JoinRetryCount;

	[Token(Token = "0x4006AD9")]
	[FieldOffset(Offset = "0x34")]
	private int m_InitRetryCount;

	[Token(Token = "0x4006ADA")]
	[FieldOffset(Offset = "0x38")]
	private RoomInfo m_CurrentRoomInfo;

	[Token(Token = "0x4006ADB")]
	[FieldOffset(Offset = "0x3C")]
	private RoomInfo m_LastJoinRequest;

	[Token(Token = "0x4006ADC")]
	[FieldOffset(Offset = "0x40")]
	private uint m_CurrentRetryJoinDelayID;

	[Token(Token = "0x4006ADD")]
	[FieldOffset(Offset = "0x44")]
	private bool m_ChannelResumed;

	[Token(Token = "0x4006ADE")]
	[FieldOffset(Offset = "0x48")]
	private EChannelPauseReason m_ChannelPauseReason;

	[Token(Token = "0x4006ADF")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<string, bool> m_PlayerVadDict;

	[Token(Token = "0x4006AE0")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<string, bool> m_PlayerMuteDict;

	[Token(Token = "0x4006AE1")]
	[FieldOffset(Offset = "0x54")]
	private float m_OwnVoiceOnTime;

	[Token(Token = "0x4006AE2")]
	[FieldOffset(Offset = "0x58")]
	private bool m_OwnVoiceIsOn;

	[Token(Token = "0x4006AE3")]
	[FieldOffset(Offset = "0x14")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4006AE4")]
	[FieldOffset(Offset = "0x18")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4006AE5")]
	[FieldOffset(Offset = "0x1C")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4006AE6")]
	[FieldOffset(Offset = "0x20")]
	private static Action _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4006AE7")]
	[FieldOffset(Offset = "0x24")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x17000898")]
	public bool Inited
	{
		[Token(Token = "0x6006536")]
		[Address(RVA = "0x2497FB4", Offset = "0x2497FB4", VA = "0x2497FB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000899")]
	public bool IsMicroPhoneMute
	{
		[Token(Token = "0x6006537")]
		[Address(RVA = "0x2498018", Offset = "0x2498018", VA = "0x2498018")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700089A")]
	public bool IsSpeakerMute
	{
		[Token(Token = "0x6006539")]
		[Address(RVA = "0x249899C", Offset = "0x249899C", VA = "0x249899C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600653A")]
		[Address(RVA = "0x24989F4", Offset = "0x24989F4", VA = "0x24989F4")]
		set
		{
		}
	}

	[Token(Token = "0x1700089B")]
	public uint GameVoiceVolume
	{
		[Token(Token = "0x600653B")]
		[Address(RVA = "0x2498A60", Offset = "0x2498A60", VA = "0x2498A60")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600653C")]
		[Address(RVA = "0x2498AB8", Offset = "0x2498AB8", VA = "0x2498AB8")]
		set
		{
		}
	}

	[Token(Token = "0x1700089C")]
	public static GameVoiceEngine Instance
	{
		[Token(Token = "0x600653D")]
		[Address(RVA = "0x2498C58", Offset = "0x2498C58", VA = "0x2498C58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700089D")]
	public RoomInfo CurrentRoomInfo
	{
		[Token(Token = "0x600653E")]
		[Address(RVA = "0x2498EBC", Offset = "0x2498EBC", VA = "0x2498EBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006535")]
	[Address(RVA = "0x2497E84", Offset = "0x2497E84", VA = "0x2497E84")]
	public GameVoiceEngine()
	{
	}

	[Token(Token = "0x6006538")]
	[Address(RVA = "0x2498070", Offset = "0x2498070", VA = "0x2498070")]
	public void ToggleMicrophoneMute(bool mute, bool request = true, bool needTips = true)
	{
	}

	[Token(Token = "0x600653F")]
	[Address(RVA = "0x2498F14", Offset = "0x2498F14", VA = "0x2498F14")]
	public void InitEngine()
	{
	}

	[Token(Token = "0x6006540")]
	[Address(RVA = "0x24994B4", Offset = "0x24994B4", VA = "0x24994B4")]
	public void JoinRoom(string roomID, string playerID, string tag = "")
	{
	}

	[Token(Token = "0x6006541")]
	[Address(RVA = "0x249A0F0", Offset = "0x249A0F0", VA = "0x249A0F0")]
	public bool IsInRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6006542")]
	[Address(RVA = "0x2499C10", Offset = "0x2499C10", VA = "0x2499C10")]
	private void JoinRoom(RoomInfo joinRequest)
	{
	}

	[Token(Token = "0x6006543")]
	[Address(RVA = "0x24997F0", Offset = "0x24997F0", VA = "0x24997F0")]
	public void LeaveRoom(bool no_clear_lastJoin = false, string tag = "")
	{
	}

	[Token(Token = "0x6006544")]
	[Address(RVA = "0x249A580", Offset = "0x249A580", VA = "0x249A580")]
	private void JoinLastRequest()
	{
	}

	[Token(Token = "0x6006545")]
	[Address(RVA = "0x249A15C", Offset = "0x249A15C", VA = "0x249A15C")]
	private void RetryJoinRoomLater(string roomID)
	{
	}

	[Token(Token = "0x6006546")]
	[Address(RVA = "0x24991A0", Offset = "0x24991A0", VA = "0x24991A0")]
	private void RetryInitLater()
	{
	}

	[Token(Token = "0x6006547")]
	[Address(RVA = "0x249A608", Offset = "0x249A608", VA = "0x249A608")]
	private void OnEvent(string strParam)
	{
	}

	[Token(Token = "0x6006548")]
	[Address(RVA = "0x249C8E0", Offset = "0x249C8E0", VA = "0x249C8E0")]
	private void OnMemberChange(string strParam)
	{
	}

	[Token(Token = "0x6006549")]
	[Address(RVA = "0x249A7E0", Offset = "0x249A7E0", VA = "0x249A7E0")]
	public void OnEvent(int event_id, int errorCode, string channelID, string param)
	{
	}

	[Token(Token = "0x600654A")]
	[Address(RVA = "0x249CB1C", Offset = "0x249CB1C", VA = "0x249CB1C")]
	private void SetPlayerVadFlag(string player_id, bool flag)
	{
	}

	[Token(Token = "0x600654B")]
	[Address(RVA = "0x249CD94", Offset = "0x249CD94", VA = "0x249CD94")]
	public bool GetPlayerVadFlag(string player_id)
	{
		return default(bool);
	}

	[Token(Token = "0x600654C")]
	[Address(RVA = "0x249CE84", Offset = "0x249CE84", VA = "0x249CE84")]
	public void MuteTargetPlayer(string player_id, bool is_mute)
	{
	}

	[Token(Token = "0x600654D")]
	[Address(RVA = "0x249D064", Offset = "0x249D064", VA = "0x249D064")]
	private void SetPlayerMuteFlag(string player_id, bool is_mute)
	{
	}

	[Token(Token = "0x600654E")]
	[Address(RVA = "0x249D2DC", Offset = "0x249D2DC", VA = "0x249D2DC")]
	public bool GetPlayerMuteFlag(string player_id)
	{
		return default(bool);
	}

	[Token(Token = "0x600654F")]
	[Address(RVA = "0x249D408", Offset = "0x249D408", VA = "0x249D408")]
	public void ReportAudioAck(string param)
	{
	}

	[Token(Token = "0x6006550")]
	[Address(RVA = "0x249E30C", Offset = "0x249E30C", VA = "0x249E30C")]
	public void AudioMuteNotify(string param)
	{
	}

	[Token(Token = "0x6006551")]
	[Address(RVA = "0x249E5AC", Offset = "0x249E5AC", VA = "0x249E5AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6006552")]
	[Address(RVA = "0x249E860", Offset = "0x249E860", VA = "0x249E860")]
	private void OnChannelResumed()
	{
	}

	[Token(Token = "0x6006553")]
	[Address(RVA = "0x249E97C", Offset = "0x249E97C", VA = "0x249E97C")]
	private void SetMicAndSpeakerMute()
	{
	}

	[Token(Token = "0x6006554")]
	[Address(RVA = "0x249EC60", Offset = "0x249EC60", VA = "0x249EC60")]
	public void OnMembetMicReleased()
	{
	}

	[Token(Token = "0x6006555")]
	[Address(RVA = "0x2498818", Offset = "0x2498818", VA = "0x2498818")]
	private void CheckMicAndSpeakerState()
	{
	}

	[Token(Token = "0x6006556")]
	[Address(RVA = "0x249EB7C", Offset = "0x249EB7C", VA = "0x249EB7C")]
	public void RefreshVoiceCaptureEnabled(bool enable)
	{
	}

	[Token(Token = "0x6006557")]
	[Address(RVA = "0x249ED58", Offset = "0x249ED58", VA = "0x249ED58")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6006558")]
	[Address(RVA = "0x249EE9C", Offset = "0x249EE9C", VA = "0x249EE9C")]
	public void DestroyGameVoiceEngine()
	{
	}

	[Token(Token = "0x6006559")]
	[Address(RVA = "0x249EFC4", Offset = "0x249EFC4", VA = "0x249EFC4")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600655B")]
	[Address(RVA = "0x249F164", Offset = "0x249F164", VA = "0x249F164")]
	private void _003CRetryJoinRoomLater_003Em__0()
	{
	}

	[Token(Token = "0x600655C")]
	[Address(RVA = "0x249F208", Offset = "0x249F208", VA = "0x249F208")]
	private void _003CRetryInitLater_003Em__1()
	{
	}

	[Token(Token = "0x600655D")]
	[Address(RVA = "0x249F2A0", Offset = "0x249F2A0", VA = "0x249F2A0")]
	private static void _003COnEvent_003Em__2()
	{
	}

	[Token(Token = "0x600655E")]
	[Address(RVA = "0x249F784", Offset = "0x249F784", VA = "0x249F784")]
	private static void _003COnEvent_003Em__3()
	{
	}

	[Token(Token = "0x600655F")]
	[Address(RVA = "0x249FBF0", Offset = "0x249FBF0", VA = "0x249FBF0")]
	private static void _003COnEvent_003Em__4()
	{
	}

	[Token(Token = "0x6006560")]
	[Address(RVA = "0x249FC84", Offset = "0x249FC84", VA = "0x249FC84")]
	private static void _003COnEvent_003Em__5()
	{
	}

	[Token(Token = "0x6006561")]
	[Address(RVA = "0x249FD00", Offset = "0x249FD00", VA = "0x249FD00")]
	private static void _003CReportAudioAck_003Em__6(HttpErrorCode errCode, object obj)
	{
	}
}
