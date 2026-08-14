using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C34")]
public class EditorMiscData
{
	[Token(Token = "0x40064AA")]
	[FieldOffset(Offset = "0x8")]
	private readonly Dictionary<uint, Dictionary<string, List<string>>> m_CustomStrings;

	[Token(Token = "0x40064AB")]
	[FieldOffset(Offset = "0xC")]
	private readonly List<OAMCFBDOEHM.HHLNNKGMAFD> m_EditorErrors;

	[Token(Token = "0x40064AC")]
	private const int ERROR_ENTRY_INITIAL_CAPACITY = 100;

	[Token(Token = "0x40064AD")]
	[FieldOffset(Offset = "0x10")]
	private readonly UGCEditorErrorComparer m_EditorErrorComparor;

	[Token(Token = "0x40064AE")]
	[FieldOffset(Offset = "0x14")]
	private readonly Dictionary<int, OAMCFBDOEHM.BFIGPFKKAGK> m_EditorErrorConfig;

	[Token(Token = "0x6005D1D")]
	[Address(RVA = "0x2F58B44", Offset = "0x2F58B44", VA = "0x2F58B44")]
	public EditorMiscData(Dictionary<int, OAMCFBDOEHM.BFIGPFKKAGK> config)
	{
	}

	[Token(Token = "0x6005D1E")]
	[Address(RVA = "0x2F4EEC8", Offset = "0x2F4EEC8", VA = "0x2F4EEC8")]
	public void AddCustomStringForInstance(FONLAPPBCOO entityType, string entityID, string content)
	{
	}

	[Token(Token = "0x6005D1F")]
	[Address(RVA = "0x2F4EDF4", Offset = "0x2F4EDF4", VA = "0x2F4EDF4")]
	public void AddCustomStringForType(FONLAPPBCOO entityType, string content)
	{
	}

	[Token(Token = "0x6005D20")]
	[Address(RVA = "0x2F58C58", Offset = "0x2F58C58", VA = "0x2F58C58")]
	public void MergeFrom(EditorMiscData otherMiscData)
	{
	}

	[Token(Token = "0x6005D21")]
	[Address(RVA = "0x2F5917C", Offset = "0x2F5917C", VA = "0x2F5917C")]
	public NCPHFLKMCKL ExportUserDataForCensorship()
	{
		return null;
	}

	[Token(Token = "0x6005D22")]
	[Address(RVA = "0x2F5968C", Offset = "0x2F5968C", VA = "0x2F5968C")]
	public void ClearAllUserDefinedString()
	{
	}

	[Token(Token = "0x6005D23")]
	[Address(RVA = "0x2F4F2EC", Offset = "0x2F4F2EC", VA = "0x2F4F2EC")]
	public void AddErrorEntry(OAMCFBDOEHM.NGPIPAPMNNF errorCode, FONLAPPBCOO entityType = FONLAPPBCOO.EUGCLogicEntityType_Unknown, string entityID = "", string graphID = "", uint itemType = 0u)
	{
	}

	[Token(Token = "0x6005D24")]
	[Address(RVA = "0x2F5974C", Offset = "0x2F5974C", VA = "0x2F5974C")]
	public int HasErrorEntry(OAMCFBDOEHM.NGPIPAPMNNF errorCode, FONLAPPBCOO entityType = FONLAPPBCOO.EUGCLogicEntityType_Unknown, string entityID = "", string graphID = "", uint itemType = 0u)
	{
		return default(int);
	}

	[Token(Token = "0x6005D25")]
	[Address(RVA = "0x2F59A08", Offset = "0x2F59A08", VA = "0x2F59A08")]
	public OAMCFBDOEHM.BFIGPFKKAGK GetFirstErrorData()
	{
		return null;
	}

	[Token(Token = "0x6005D26")]
	[Address(RVA = "0x2F5A310", Offset = "0x2F5A310", VA = "0x2F5A310")]
	public void SortAllErrors()
	{
	}

	[Token(Token = "0x6005D27")]
	[Address(RVA = "0x2F5A3D8", Offset = "0x2F5A3D8", VA = "0x2F5A3D8")]
	public IEnumerator<OAMCFBDOEHM.HHLNNKGMAFD> IterateAllErrors()
	{
		return null;
	}

	[Token(Token = "0x6005D28")]
	[Address(RVA = "0x2F5A4CC", Offset = "0x2F5A4CC", VA = "0x2F5A4CC")]
	public void RemoveAllErrors()
	{
	}

	[Token(Token = "0x6005D29")]
	[Address(RVA = "0x2F5A58C", Offset = "0x2F5A58C", VA = "0x2F5A58C")]
	public OAMCFBDOEHM.NGPIPAPMNNF[] ExportSortedErrors()
	{
		return null;
	}

	[Token(Token = "0x6005D2A")]
	[Address(RVA = "0x2F5A5E4", Offset = "0x2F5A5E4", VA = "0x2F5A5E4")]
	public Dictionary<uint, uint> ExportErrorSummary()
	{
		return null;
	}
}
