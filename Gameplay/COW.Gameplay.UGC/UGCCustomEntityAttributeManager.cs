using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C23")]
public class UGCCustomEntityAttributeManager : MonoSingleton<UGCCustomEntityAttributeManager>
{
	[Token(Token = "0x2000C24")]
	private sealed class _003CHasEntityCustomAttribute_003Ec__AnonStorey0
	{
		[Token(Token = "0x400647B")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x6005CD9")]
		[Address(RVA = "0x2F5DB10", Offset = "0x2F5DB10", VA = "0x2F5DB10")]
		public _003CHasEntityCustomAttribute_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6005CDA")]
		[Address(RVA = "0x2F5EB64", Offset = "0x2F5EB64", VA = "0x2F5EB64")]
		internal bool _003C_003Em__0(GALLODIEHAA data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4006479")]
	[FieldOffset(Offset = "0xC")]
	private EditorEntityData m_EditorEntityData;

	[Token(Token = "0x400647A")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, CEIJKFCIALJ> m_TypeEntityAttributeDic;

	[Token(Token = "0x170007EB")]
	private EditorEntityData EditorEntityData
	{
		[Token(Token = "0x6005CBF")]
		[Address(RVA = "0x2F5C3CC", Offset = "0x2F5C3CC", VA = "0x2F5C3CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007EC")]
	public Dictionary<uint, CEIJKFCIALJ> TypeEntityAttributeDic
	{
		[Token(Token = "0x6005CC0")]
		[Address(RVA = "0x2F5C530", Offset = "0x2F5C530", VA = "0x2F5C530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005CBE")]
	[Address(RVA = "0x2F5C33C", Offset = "0x2F5C33C", VA = "0x2F5C33C")]
	public UGCCustomEntityAttributeManager()
	{
	}

	[Token(Token = "0x6005CC1")]
	[Address(RVA = "0x2F5C588", Offset = "0x2F5C588", VA = "0x2F5C588", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6005CC2")]
	[Address(RVA = "0x2F5C668", Offset = "0x2F5C668", VA = "0x2F5C668")]
	public void AfterLoadProject()
	{
	}

	[Token(Token = "0x6005CC3")]
	[Address(RVA = "0x2F5C950", Offset = "0x2F5C950", VA = "0x2F5C950")]
	public void Clean()
	{
	}

	[Token(Token = "0x6005CC4")]
	[Address(RVA = "0x2F5CA10", Offset = "0x2F5CA10", VA = "0x2F5CA10")]
	public byte[] ToBytes()
	{
		return null;
	}

	[Token(Token = "0x6005CC5")]
	[Address(RVA = "0x2F5CAD4", Offset = "0x2F5CAD4", VA = "0x2F5CAD4")]
	public bool FromBytes(byte[] dataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CC6")]
	[Address(RVA = "0x2F5CBC4", Offset = "0x2F5CBC4", VA = "0x2F5CBC4")]
	public List<CEIJKFCIALJ> ExportReplicationData()
	{
		return null;
	}

	[Token(Token = "0x6005CC7")]
	[Address(RVA = "0x2F5CDD8", Offset = "0x2F5CDD8", VA = "0x2F5CDD8")]
	public void SetTypeEntity(FONLAPPBCOO type, CEIJKFCIALJ data)
	{
	}

	[Token(Token = "0x6005CC8")]
	[Address(RVA = "0x2F5C7EC", Offset = "0x2F5C7EC", VA = "0x2F5C7EC")]
	public bool AddTypeEntity(FONLAPPBCOO type)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CC9")]
	[Address(RVA = "0x2F5CEC0", Offset = "0x2F5CEC0", VA = "0x2F5CEC0")]
	public bool CheckNameExist(string name, CEIJKFCIALJ customData, [Optional] DJMFJEMEKHM excludeData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CCA")]
	[Address(RVA = "0x2F5C720", Offset = "0x2F5C720", VA = "0x2F5C720")]
	public bool HasTypeEntity(FONLAPPBCOO type)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CCB")]
	[Address(RVA = "0x2F5D0D8", Offset = "0x2F5D0D8", VA = "0x2F5D0D8")]
	public string GetAttributeName(FONLAPPBCOO type, int index)
	{
		return null;
	}

	[Token(Token = "0x6005CCC")]
	[Address(RVA = "0x2F5D2AC", Offset = "0x2F5D2AC", VA = "0x2F5D2AC")]
	private List<DJMFJEMEKHM> CopyReplicationDataItem(List<DJMFJEMEKHM> data)
	{
		return null;
	}

	[Token(Token = "0x6005CCD")]
	[Address(RVA = "0x2F5D748", Offset = "0x2F5D748", VA = "0x2F5D748")]
	public CEIJKFCIALJ GetCustomReplicatioEntityData(FONLAPPBCOO type)
	{
		return null;
	}

	[Token(Token = "0x6005CCE")]
	[Address(RVA = "0x2F5D84C", Offset = "0x2F5D84C", VA = "0x2F5D84C")]
	public bool HasCustomReplicatioEntityAttribute(FONLAPPBCOO type, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CCF")]
	[Address(RVA = "0x2F5D9A4", Offset = "0x2F5D9A4", VA = "0x2F5D9A4")]
	public bool HasEntityCustomAttribute(string entityId, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD0")]
	[Address(RVA = "0x2F5DBB8", Offset = "0x2F5DBB8", VA = "0x2F5DBB8")]
	public CEIJKFCIALJ GetNewCustomReplicatioEntityData(FONLAPPBCOO type)
	{
		return null;
	}

	[Token(Token = "0x6005CD1")]
	[Address(RVA = "0x2F5DD88", Offset = "0x2F5DD88", VA = "0x2F5DD88")]
	private List<GALLODIEHAA> CopyReplicationDataToInstance(List<DJMFJEMEKHM> oriList)
	{
		return null;
	}

	[Token(Token = "0x6005CD2")]
	[Address(RVA = "0x2F5DFAC", Offset = "0x2F5DFAC", VA = "0x2F5DFAC")]
	public bool CreateInstanceEntity(FONLAPPBCOO entityType, string entityID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD3")]
	[Address(RVA = "0x2F5DB18", Offset = "0x2F5DB18", VA = "0x2F5DB18")]
	public List<GALLODIEHAA> GetInstanceEntityCustomAttributes(string id)
	{
		return null;
	}

	[Token(Token = "0x6005CD4")]
	[Address(RVA = "0x2F5E180", Offset = "0x2F5E180", VA = "0x2F5E180")]
	public bool HasEntity(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD5")]
	[Address(RVA = "0x2F5E29C", Offset = "0x2F5E29C", VA = "0x2F5E29C")]
	public void DeleteInstanceEntityAttribute(FONLAPPBCOO type, int index)
	{
	}

	[Token(Token = "0x6005CD6")]
	[Address(RVA = "0x2F5D588", Offset = "0x2F5D588", VA = "0x2F5D588")]
	private EGKJIDMCGML GetNewVarValueData(EGKJIDMCGML oriData)
	{
		return null;
	}

	[Token(Token = "0x6005CD7")]
	[Address(RVA = "0x2F5E518", Offset = "0x2F5E518", VA = "0x2F5E518")]
	public void RedefineInstanceEntityAttribute(FONLAPPBCOO type, HashSet<int> indexList, bool reDefineAll = false)
	{
	}

	[Token(Token = "0x6005CD8")]
	[Address(RVA = "0x2F5EB60", Offset = "0x2F5EB60", VA = "0x2F5EB60")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
