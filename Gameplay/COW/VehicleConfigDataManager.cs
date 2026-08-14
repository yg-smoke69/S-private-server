using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;

namespace COW;

[Token(Token = "0x200025D")]
public class VehicleConfigDataManager : SingletonModule<VehicleConfigDataManager>
{
	[Token(Token = "0x4000E4C")]
	public const bool CacheConfigs = true;

	[Token(Token = "0x4000E4D")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, VehicleConfigDataMap> m_Dic;

	[Token(Token = "0x4000E4E")]
	[FieldOffset(Offset = "0x10")]
	private uint m_CurrentDataId;

	[Token(Token = "0x4000E4F")]
	[FieldOffset(Offset = "0x14")]
	private VehicleConfigDataMap m_CurrentData;

	[Token(Token = "0x4000E50")]
	[FieldOffset(Offset = "0x18")]
	private VehicleConfigDataMap m_DefaultData;

	[Token(Token = "0x4000E51")]
	[FieldOffset(Offset = "0x0")]
	private static ImporterFunc<double, float> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x4")]
	private static ImporterFunc<string, BoxCollider> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x219A9F0", Offset = "0x219A9F0", VA = "0x219A9F0")]
	public VehicleConfigDataManager()
	{
	}

	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x219AA80", Offset = "0x219AA80", VA = "0x219AA80")]
	public VehicleConfigData GetConfigData(uint mapId, uint modeId, int vehId)
	{
		return null;
	}

	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x219AB9C", Offset = "0x219AB9C", VA = "0x219AB9C")]
	internal VehicleConfigDataMap GetConfigData(uint mapId, uint modeId)
	{
		return null;
	}

	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x219ACE8", Offset = "0x219ACE8", VA = "0x219ACE8")]
	private VehicleConfigDataMap LoadAndStoreConfigData(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x219B070", Offset = "0x219B070", VA = "0x219B070")]
	private VehicleConfigDataMap LoadAndStoreDefaultConfigData()
	{
		return null;
	}

	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x219B138", Offset = "0x219B138", VA = "0x219B138")]
	private VehicleConfigDataMap LoadAndStoreConfigData(ResourceID resID)
	{
		return null;
	}

	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0x219B4B8", Offset = "0x219B4B8", VA = "0x219B4B8")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x219B51C", Offset = "0x219B51C", VA = "0x219B51C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x219B570", Offset = "0x219B570", VA = "0x219B570", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x219B5D0", Offset = "0x219B5D0", VA = "0x219B5D0")]
	private static BoxCollider _003CLoadAndStoreConfigData_003Em__0(string input)
	{
		return null;
	}
}
