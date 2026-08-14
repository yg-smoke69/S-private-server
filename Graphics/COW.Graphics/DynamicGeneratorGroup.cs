using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F40")]
public class DynamicGeneratorGroup : MonoBehaviour
{
	[Token(Token = "0x401AA82")]
	[FieldOffset(Offset = "0xC")]
	public List<BFPFFNANJAM.DynamicPrefabInfo> m_dynamicPrefabList;

	[Token(Token = "0x401AA83")]
	[FieldOffset(Offset = "0x10")]
	public List<BFPFFNANJAM.DynamicPrefabInfo> m_dynamicGroupPrefabList;

	[Token(Token = "0x401AA84")]
	[FieldOffset(Offset = "0x14")]
	public List<BFPFFNANJAM.DistributionData> m_distributionList;

	[Token(Token = "0x6019C3F")]
	[Address(RVA = "0x25A85D0", Offset = "0x25A85D0", VA = "0x25A85D0")]
	public DynamicGeneratorGroup()
	{
	}
}
