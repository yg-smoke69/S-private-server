using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F0A")]
public interface IShape2D
{
	[Token(Token = "0x6019ABE")]
	Vector3 GetPosition();

	[Token(Token = "0x6019ABF")]
	Vector3 GetCenter();

	[Token(Token = "0x6019AC0")]
	Vector3 GetSize();

	[Token(Token = "0x6019AC1")]
	bool IsPointInside(Vector3 v, float margin = 0f);

	[Token(Token = "0x6019AC2")]
	Vector3 GetRandomPoint(float margin = 0f);

	[Token(Token = "0x6019AC3")]
	Vector3 ClampPoint(Vector3 v, float margin = 0f);
}
