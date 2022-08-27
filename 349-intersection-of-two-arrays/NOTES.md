HashSet<int> sets = new HashSet<int>(nums2);
HashSet<int> intersection = new HashSet<int>(nums1);
sets.IntersectWith(intersection);
return sets.ToArray();