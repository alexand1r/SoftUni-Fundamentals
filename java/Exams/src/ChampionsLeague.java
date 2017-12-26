import java.util.*;
import java.util.stream.Collectors;

/**
 * Created by Alec on 14.04.2016 г..
 */
public class ChampionsLeague {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, Integer> teamsWithScore = new TreeMap<String, Integer>();
        TreeMap<String, TreeSet<String>> teamsWithOpponents = new TreeMap<String, TreeSet<String>>();

        String inputLine = scanner.nextLine().trim();

        while(!inputLine.equals("stop")){

            String[] inputArgs = inputLine.split("[|]+");

            String firstTeamName = inputArgs[0].trim();
            String secondTeamName = inputArgs[1].trim();
            String[] homeResult = inputArgs[2].trim().split(":");
            String[] awayResult = inputArgs[3].trim().split(":");

            Integer homeResultFirstTeam = Integer.parseInt(homeResult[0]);
            Integer homeResultSecondTeam = Integer.parseInt(homeResult[1]);

            Integer awayResultSecondTeam = Integer.parseInt(awayResult[0]);
            Integer awayResultFirstTeam = Integer.parseInt(awayResult[1]);

            if(homeResultFirstTeam + awayResultFirstTeam > homeResultSecondTeam + awayResultSecondTeam){
                if(teamsWithScore.containsKey(firstTeamName)){
                    Integer oldValue = teamsWithScore.get(firstTeamName);
                    teamsWithScore.replace(firstTeamName, oldValue + 1);

                    TreeSet<String> opponents = teamsWithOpponents.get(firstTeamName);
                    opponents.add(secondTeamName);
                    teamsWithOpponents.replace(firstTeamName, opponents);
                    if(!teamsWithScore.containsKey(secondTeamName)){
                        teamsWithScore.put(secondTeamName, 0);
                        TreeSet<String> enemyOponents = new TreeSet<String>();
                        enemyOponents.add(firstTeamName);
                        teamsWithOpponents.put(secondTeamName, enemyOponents);
                    }
                    else{
                        TreeSet<String> enemyOponents = teamsWithOpponents.get(secondTeamName);
                        enemyOponents.add(firstTeamName);
                        teamsWithOpponents.replace(secondTeamName, enemyOponents);
                    }
                }
                else{
                    teamsWithScore.put(firstTeamName, 1);
                    TreeSet<String> oponents = new TreeSet<String>();
                    oponents.add(secondTeamName);

                    teamsWithOpponents.put(firstTeamName, oponents);
                    if(!teamsWithScore.containsKey(secondTeamName)){
                        teamsWithScore.put(secondTeamName, 0);
                        TreeSet<String> enemyOponents = new TreeSet<String>();
                        enemyOponents.add(firstTeamName);
                        teamsWithOpponents.put(secondTeamName, enemyOponents);
                    }
                    else{
                        TreeSet<String> enemyOponents = teamsWithOpponents.get(secondTeamName);
                        enemyOponents.add(firstTeamName);
                        teamsWithOpponents.replace(secondTeamName, enemyOponents);
                    }
                }
            }
            else if(homeResultFirstTeam + awayResultFirstTeam < homeResultSecondTeam + awayResultSecondTeam){
                if(teamsWithScore.containsKey(secondTeamName)){
                    Integer oldValue = teamsWithScore.get(secondTeamName);
                    teamsWithScore.replace(secondTeamName, oldValue + 1);

                    TreeSet<String> oponents = teamsWithOpponents.get(secondTeamName);
                    oponents.add(firstTeamName);
                    teamsWithOpponents.replace(secondTeamName, oponents);
                    if(!teamsWithScore.containsKey(firstTeamName)){
                        teamsWithScore.put(firstTeamName, 0);
                        TreeSet<String> enemyOponents = new TreeSet<String>();
                        enemyOponents.add(secondTeamName);
                        teamsWithOpponents.put(firstTeamName, enemyOponents);
                    }
                    else{
                        TreeSet<String> enemyOponents = teamsWithOpponents.get(firstTeamName);
                        enemyOponents.add(secondTeamName);
                        teamsWithOpponents.replace(firstTeamName, enemyOponents);
                    }
                }
                else{
                    teamsWithScore.put(secondTeamName, 1);
                    TreeSet<String> oponents = new TreeSet<String>();
                    oponents.add(firstTeamName);

                    teamsWithOpponents.put(secondTeamName, oponents);
                    if(!teamsWithScore.containsKey(firstTeamName)){
                        teamsWithScore.put(firstTeamName, 0);
                        TreeSet<String> enemyOponents = new TreeSet<String>();
                        enemyOponents.add(secondTeamName);
                        teamsWithOpponents.put(firstTeamName, enemyOponents);
                    }
                    else{
                        TreeSet<String> enemyOponents = teamsWithOpponents.get(firstTeamName);
                        enemyOponents.add(secondTeamName);
                        teamsWithOpponents.replace(firstTeamName, enemyOponents);
                    }
                }
            }
            else if(homeResultFirstTeam + awayResultFirstTeam == homeResultSecondTeam + awayResultSecondTeam){
                String winnerTeamName = awayResultFirstTeam > homeResultSecondTeam ? firstTeamName : secondTeamName;
                String loserTeamName = awayResultFirstTeam > homeResultSecondTeam ? secondTeamName : firstTeamName;

                if(teamsWithScore.containsKey(winnerTeamName)){
                    Integer oldValue = teamsWithScore.get(winnerTeamName);
                    teamsWithScore.replace(winnerTeamName, oldValue + 1);

                    TreeSet<String> oponents = teamsWithOpponents.get(winnerTeamName);
                    oponents.add(loserTeamName);
                    teamsWithOpponents.replace(winnerTeamName, oponents);
                    if(!teamsWithScore.containsKey(loserTeamName)){
                        teamsWithScore.put(loserTeamName, 0);
                        TreeSet<String> enemyOponents = new TreeSet<String>();
                        enemyOponents.add(winnerTeamName);
                        teamsWithOpponents.put(loserTeamName, enemyOponents);
                    }
                    else{
                        TreeSet<String> enemyOponents = teamsWithOpponents.get(loserTeamName);
                        enemyOponents.add(winnerTeamName);
                        teamsWithOpponents.replace(loserTeamName, enemyOponents);
                    }
                }
                else{
                    teamsWithScore.put(winnerTeamName, 1);
                    TreeSet<String> oponents = new TreeSet<String>();
                    oponents.add(loserTeamName);

                    teamsWithOpponents.put(winnerTeamName, oponents);
                    if(!teamsWithScore.containsKey(loserTeamName)){
                        teamsWithScore.put(loserTeamName, 0);
                        TreeSet<String> enemyOponents = new TreeSet<String>();
                        enemyOponents.add(winnerTeamName);
                        teamsWithOpponents.put(loserTeamName, enemyOponents);
                    }
                    else{
                        TreeSet<String> enemyOponents = teamsWithOpponents.get(loserTeamName);
                        enemyOponents.add(winnerTeamName);
                        teamsWithOpponents.replace(loserTeamName, enemyOponents);
                    }
                }
            }

            inputLine = scanner.nextLine().trim();
        }

        Map<String, Integer> sortedTeamsByScore = new LinkedHashMap<String, Integer>();
        sortedTeamsByScore = teamsWithScore.entrySet().stream().sorted(new Comparator<Map.Entry<String, Integer>>() {
            @Override
            public int compare(Map.Entry<String, Integer> o1, Map.Entry<String, Integer> o2) {
                return o2.getValue().compareTo(o1.getValue());
            }
        }).collect(
                Collectors.toMap(
                        Map.Entry::getKey,
                        Map.Entry::getValue,
                        (x,y)-> {throw new AssertionError();},
                        LinkedHashMap::new
                ));

        for(Map.Entry e : sortedTeamsByScore.entrySet()){
            System.out.println(String.format("%s", e.getKey()));
            System.out.println(String.format("- Wins: %s", e.getValue()));
            System.out.println(String.format("- Opponents: %s", String.join(", ", teamsWithOpponents.get(e.getKey()))));
        }
    }
}
