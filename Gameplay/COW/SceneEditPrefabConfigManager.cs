using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000224")]
public class SceneEditPrefabConfigManager : SingletonModule<SceneEditPrefabConfigManager>
{
	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0xC")]
	private List<SceneEditPrefabConfigData> mPrefabConfigDataList;

	[Token(Token = "0x17000160")]
	public List<SceneEditPrefabConfigData> PrefabConfigDataList
	{
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x2420C2C", Offset = "0x2420C2C", VA = "0x2420C2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000ADD")]
	[Address(RVA = "0x2420B68", Offset = "0x2420B68", VA = "0x2420B68")]
	public SceneEditPrefabConfigManager()
	{
	}

	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0x2420C84", Offset = "0x2420C84", VA = "0x2420C84", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000AE0")]
	[Address(RVA = "0x2420DA8", Offset = "0x2420DA8", VA = "0x2420DA8")]
	public void Load()
	{
	}

	[Token(Token = "0x6000AE1")]
	[Address(RVA = "0x2420EEC", Offset = "0x2420EEC", VA = "0x2420EEC", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0x2420FA8", Offset = "0x2420FA8", VA = "0x2420FA8")]
	public SceneEditPrefabConfigData GetPrefabConfigData(uint itemID)
	{
		return null;
	}

	[Token(Token = "0x6000AE3")]
	[Address(RVA = "0x24211D4", Offset = "0x24211D4", VA = "0x24211D4")]
	public void GetPrefabConfigDataByType(uint typeID, ref List<SceneEditPrefabConfigData> ret)
	{
	}

	[Token(Token = "0x6000AE4")]
	[Address(RVA = "0x2421244", Offset = "0x2421244", VA = "0x2421244")]
	public void GetPrefabConfigDataByItemType(uint itemType, ref List<SceneEditPrefabConfigData> ret)
	{
	}
}
