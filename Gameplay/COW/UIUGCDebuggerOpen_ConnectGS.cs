using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using message;
using tcp;

namespace COW;

[Token(Token = "0x2000C25")]
public class UIUGCDebuggerOpen_ConnectGS : MonoBehaviour
{
	[Token(Token = "0x2000C26")]
	public class HTTP_CreateRoomResp
	{
		[Token(Token = "0x400647E")]
		[FieldOffset(Offset = "0x8")]
		public int RetCode;

		[Token(Token = "0x400647F")]
		[FieldOffset(Offset = "0x10")]
		public ulong ServiceRoomID;

		[Token(Token = "0x4006480")]
		[FieldOffset(Offset = "0x18")]
		public string ServerAddr;

		[Token(Token = "0x4006481")]
		[FieldOffset(Offset = "0x1C")]
		public string ErrorString;

		[Token(Token = "0x4006482")]
		[FieldOffset(Offset = "0x20")]
		public string Secret;

		[Token(Token = "0x4006483")]
		[FieldOffset(Offset = "0x24")]
		public uint MapID;

		[Token(Token = "0x4006484")]
		[FieldOffset(Offset = "0x28")]
		public uint GameMode;

		[Token(Token = "0x4006485")]
		[FieldOffset(Offset = "0x2C")]
		public uint GroupMode;

		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0x2B95678", Offset = "0x2B95678", VA = "0x2B95678")]
		public HTTP_CreateRoomResp()
		{
		}
	}

	[Token(Token = "0x2000C27")]
	public delegate bool RunGameAction(string serverAdd, ulong serviceRoomID, string secret, uint mapid, uint gamemode, uint groupmode);

	[Token(Token = "0x2000C28")]
	private sealed class _003CStartReqest_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4006486")]
		[FieldOffset(Offset = "0x8")]
		internal string serverIPPort;

		[Token(Token = "0x4006487")]
		[FieldOffset(Offset = "0xC")]
		internal string _003Curl_003E__0;

		[Token(Token = "0x4006488")]
		[FieldOffset(Offset = "0x10")]
		internal byte[] ugcLevelData;

		[Token(Token = "0x4006489")]
		[FieldOffset(Offset = "0x14")]
		internal UnityWebRequest _003Cwww_003E__0;

		[Token(Token = "0x400648A")]
		[FieldOffset(Offset = "0x18")]
		internal ulong accountID;

		[Token(Token = "0x400648B")]
		[FieldOffset(Offset = "0x20")]
		internal uint mapid;

		[Token(Token = "0x400648C")]
		[FieldOffset(Offset = "0x24")]
		internal string nickName;

		[Token(Token = "0x400648D")]
		[FieldOffset(Offset = "0x28")]
		internal uint gamemode;

		[Token(Token = "0x400648E")]
		[FieldOffset(Offset = "0x2C")]
		internal bool isGotoPositionAfterStart;

		[Token(Token = "0x400648F")]
		[FieldOffset(Offset = "0x30")]
		internal Vector3 gotoPosition;

		[Token(Token = "0x4006490")]
		[FieldOffset(Offset = "0x3C")]
		internal string _003CBotCountByTeamStr_003E__0;

		[Token(Token = "0x4006491")]
		[FieldOffset(Offset = "0x40")]
		internal uint[] botCountByTeam;

		[Token(Token = "0x4006492")]
		[FieldOffset(Offset = "0x48")]
		internal long matchid;

		[Token(Token = "0x4006493")]
		[FieldOffset(Offset = "0x50")]
		internal string mapCDNUrl;

		[Token(Token = "0x4006494")]
		[FieldOffset(Offset = "0x54")]
		internal List<string> breakpoints;

		[Token(Token = "0x4006495")]
		[FieldOffset(Offset = "0x58")]
		internal string _003CjsonResp_003E__0;

		[Token(Token = "0x4006496")]
		[FieldOffset(Offset = "0x5C")]
		internal HTTP_CreateRoomResp _003Cresp_003E__0;

		[Token(Token = "0x4006497")]
		[FieldOffset(Offset = "0x60")]
		internal RunGameAction runGameAction;

		[Token(Token = "0x4006498")]
		[FieldOffset(Offset = "0x64")]
		internal object _0024current;

		[Token(Token = "0x4006499")]
		[FieldOffset(Offset = "0x68")]
		internal bool _0024disposing;

		[Token(Token = "0x400649A")]
		[FieldOffset(Offset = "0x6C")]
		internal int _0024PC;

		[Token(Token = "0x170007ED")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005CE7")]
			[Address(RVA = "0x2B955CC", Offset = "0x2B955CC", VA = "0x2B955CC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005CE8")]
			[Address(RVA = "0x2B955D4", Offset = "0x2B955D4", VA = "0x2B955D4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x2B94300", Offset = "0x2B94300", VA = "0x2B94300")]
		public _003CStartReqest_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6005CE6")]
		[Address(RVA = "0x2B9430C", Offset = "0x2B9430C", VA = "0x2B9430C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005CE9")]
		[Address(RVA = "0x2B955DC", Offset = "0x2B955DC", VA = "0x2B955DC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005CEA")]
		[Address(RVA = "0x2B955F0", Offset = "0x2B955F0", VA = "0x2B955F0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400647C")]
	[FieldOffset(Offset = "0x0")]
	public static ulong LastServiceRoomID;

	[Token(Token = "0x400647D")]
	[FieldOffset(Offset = "0x8")]
	private static RunGameAction _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x6005CDB")]
	[Address(RVA = "0x2B9377C", Offset = "0x2B9377C", VA = "0x2B9377C")]
	public UIUGCDebuggerOpen_ConnectGS()
	{
	}

	[Token(Token = "0x6005CDC")]
	[Address(RVA = "0x2B93784", Offset = "0x2B93784", VA = "0x2B93784")]
	public static UIUGCDebuggerOpen_ConnectGS BeginConnect(string httpIPPort, string mapCDNUrl, long matchid, UGCDebugStartReq req, DPDCNPLHENA settings)
	{
		return null;
	}

	[Token(Token = "0x6005CDD")]
	[Address(RVA = "0x2B93F9C", Offset = "0x2B93F9C", VA = "0x2B93F9C")]
	public static bool LoadGame(string serverAdd, ulong serviceRoomID, string secret, uint mapid, uint gamemode, uint groupmode)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CDE")]
	[Address(RVA = "0x2B93CC4", Offset = "0x2B93CC4", VA = "0x2B93CC4")]
	public IEnumerator StartReqest(RunGameAction runGameAction, string serverIPPort, ulong accountID, uint mapid, string nickName, uint gamemode, bool isGotoPositionAfterStart, Vector3 gotoPosition, uint[] botCountByTeam, byte[] ugcLevelData, long matchid = 0L, string mapCDNUrl = "", [Optional] List<string> breakpoints)
	{
		return null;
	}
}
