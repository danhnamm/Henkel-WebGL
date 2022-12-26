/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2020 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

using UnityEngine;

namespace FancyScrollView.Example09
{
    class Example09 : MonoBehaviour
    {
        readonly ItemData[] itemData =
        {
            new ItemData(
                "17h-18h30: Red Carpet ",
                "Greeting guests & Taking Photographs .",
                "https://images.unsplash.com/flagged/photo-1557907119-57a5724a7f92?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1374&q=80"
            ),
            new ItemData(
                "18h30 - 19h: Speech",
                " Pre-Speech of Director & Cast.",
                "https://images.unsplash.com/photo-1587825140708-dfaf72ae4b04?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80"
            ),
            new ItemData(
                "19h - 21h: Movie time",
                "",
                "https://images.unsplash.com/photo-1517604931442-7e0c8ed2963c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80"
            ),
            new ItemData(
                "21h - 24h Night Event",
                "After-Party for  Celebrities & Journalists.",
                "https://thumb.ex-cdn.com/EXP/media.vntravellive.com/resize/985x535/files/news/2022/01/24/a-night-on-earth--mot-thuc-uong-am-long-ngay-tet-103809.jpg"
            ),
           /* new ItemData(
                "04_Metaball",
                "Example of metaball implementation using shaders.",
                "https://images.unsplash.com/photo-1517604931442-7e0c8ed2963c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80"
            ),
            new ItemData(
                "05_Voronoi",
                "Example of voronoi implementation using shaders.",
                "https://setchi.jp/FancyScrollView/09_LoadTexture/Images/05.png"
            ),
            new ItemData(
                "06_LoopTabBar",
                "Example of switching screens with tabs.",
                "https://setchi.jp/FancyScrollView/09_LoadTexture/Images/06.png"
            ),
            new ItemData(
                "07_ScrollRect",
                "Example of ScrollRect style implementation with scroll bar.",
                "https://setchi.jp/FancyScrollView/09_LoadTexture/Images/07.png"
            ),
            new ItemData(
                "08_GridView",
                "Example of grid layout implementation.",
                "https://setchi.jp/FancyScrollView/09_LoadTexture/Images/08.png"
            ),
            new ItemData(
                "09_LoadTexture",
                "Example of load texture implementation.",
                "https://setchi.jp/FancyScrollView/09_LoadTexture/Images/09.png"
            )*/
        };

        [SerializeField] ScrollView scrollView = default;

        void Start()
        {
            scrollView.UpdateData(itemData);
        }
    }
}
