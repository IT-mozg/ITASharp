fun main(arg: Array<String>){
    var comps: Array<Computer> = arrayOf<Computer>(Mac(
            "1".hashCode().toString()),
            Mac("2".hashCode().toString()),
            PC("3".hashCode().toString()))
    println()
    for (i in comps.indices)
        System.out.println(comps[i])

}