using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000863")]
public class UGCLevelParamsHelper
{
	[Token(Token = "0x2000864")]
	public class UGCLevelParams
	{
		[Token(Token = "0x4005280")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, bool> paramsBool;

		[Token(Token = "0x4005281")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<string, int> paramsInt;

		[Token(Token = "0x4005282")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, float> paramsFloat;

		[Token(Token = "0x4005283")]
		[FieldOffset(Offset = "0x14")]
		public Dictionary<string, string> paramsString;

		[Token(Token = "0x6003AC8")]
		[Address(RVA = "0x2586348", Offset = "0x2586348", VA = "0x2586348")]
		public UGCLevelParams()
		{
		}
	}

	[Token(Token = "0x400527E")]
	[FieldOffset(Offset = "0x8")]
	private UGCLevelParams m_LevelParams;

	[Token(Token = "0x400527F")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, UGCRoomParamsItem> m_RoomParamsConfig;

	[Token(Token = "0x6003AC0")]
	[Address(RVA = "0x25858A8", Offset = "0x25858A8", VA = "0x25858A8")]
	public UGCLevelParamsHelper()
	{
	}

	[Token(Token = "0x6003AC1")]
	[Address(RVA = "0x25862E4", Offset = "0x25862E4", VA = "0x25862E4")]
	private void LoadRoomParamsConfig()
	{
	}

	[Token(Token = "0x6003AC2")]
	[Address(RVA = "0x25858D0", Offset = "0x25858D0", VA = "0x25858D0")]
	private void InitLevelParams()
	{
	}

	[Token(Token = "0x6003AC3")]
	[Address(RVA = "0x2585E48", Offset = "0x2585E48", VA = "0x2585E48")]
	private void LevelParamSave2Game()
	{
	}

	[Token(Token = "0x6003AC4")]
	[Address(RVA = "0x2586470", Offset = "0x2586470", VA = "0x2586470")]
	public bool GetLevelParamsBool(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6003AC5")]
	[Address(RVA = "0x2586568", Offset = "0x2586568", VA = "0x2586568")]
	public int GetLevelParamsInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x6003AC6")]
	[Address(RVA = "0x2586658", Offset = "0x2586658", VA = "0x2586658")]
	public float GetLevelParamsFloat(string key)
	{
		return default(float);
	}

	[Token(Token = "0x6003AC7")]
	[Address(RVA = "0x2586750", Offset = "0x2586750", VA = "0x2586750")]
	public string GetLevelParamsString(string key)
	{
		return null;
	}
}
