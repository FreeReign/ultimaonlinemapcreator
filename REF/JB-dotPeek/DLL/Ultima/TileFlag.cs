// Decompiled with JetBrains decompiler
// Type: Ultima.TileFlag
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;

namespace Ultima
{
  [Flags]
  public enum TileFlag
  {
    None = 0,
    Background = 1,
    Weapon = 2,
    Transparent = 4,
    Translucent = 8,
    Wall = 16,
    Damaging = 32,
    Impassable = 64,
    Wet = 128,
    Unknown1 = 256,
    Surface = 512,
    Bridge = 1024,
    Generic = 2048,
    Window = 4096,
    NoShoot = 8192,
    ArticleA = 16384,
    ArticleAn = 32768,
    Internal = 65536,
    Foliage = 131072,
    PartialHue = 262144,
    Unknown2 = 524288,
    Map = 1048576,
    Container = 2097152,
    Wearable = 4194304,
    LightSource = 8388608,
    Animation = 16777216,
    NoDiagonal = 33554432,
    Unknown3 = 67108864,
    Armor = 134217728,
    Roof = 268435456,
    Door = 536870912,
    StairBack = 1073741824,
    StairRight = -2147483648,
  }
}
