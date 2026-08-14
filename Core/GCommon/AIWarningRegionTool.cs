using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20005A3")]
public class AIWarningRegionTool
{
	[Token(Token = "0x600224D")]
	[Address(RVA = "0x26B1F24", Offset = "0x26B1F24", VA = "0x26B1F24")]
	public AIWarningRegionTool()
	{
	}

	[Token(Token = "0x600224E")]
	public static IAIWarningRegion CreateWarningRegion<T0, T>(ResourceID regionResID, Vector3 Pos, Quaternion Rot, _00211 initParam) where T0 : AIWarningRegion<_00211>
	{
		return null;
	}

	[Token(Token = "0x600224F")]
	[Address(RVA = "0x26B1F2C", Offset = "0x26B1F2C", VA = "0x26B1F2C")]
	public static IAIWarningRegion CreateCircleRegion(ResourceID regionResID, Vector3 Pos, Quaternion Rot, float radius)
	{
		return null;
	}

	[Token(Token = "0x6002250")]
	[Address(RVA = "0x26B2020", Offset = "0x26B2020", VA = "0x26B2020")]
	public static IAIWarningRegion CreateQuadRegion(ResourceID regionResID, Vector3 Pos, Quaternion Rot, float width, float height, float length)
	{
		return null;
	}
}
